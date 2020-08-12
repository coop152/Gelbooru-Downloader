using GelbooruDownloader.Logic;
using GelbooruDownloader.Properties;
using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace GelbooruDownloader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Transfer.IsAPI = true;
            InitWebsiteDropdown();
            leftStatusLabel.Text = "Welcome!";
            rightStatusLabel.Text = "0 / 0";

            if (Properties.Settings.Default.Path != null || Properties.Settings.Default.Path != "")
            {
                folderBrowserDialog.SelectedPath = Properties.Settings.Default.Path;
            }

            //if (!CheckForInternetConnection(Paths.BasePath))
            //{
            //    if (MessageBox.Show("You are offline, please check your internet connection", "Unable to connect to Rule34.xxx", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            //    {
            //        //Form1_Load(sender, e);
            //    }
            //    else
            //    {
            //        Close();
            //    }
            //}
        }
        private void InitWebsiteDropdown()
        {
            Paths.Sources = Settings.Default.WebsitesJSON.Cast<string>().ToList();
            Paths.BasePath = Paths.Sources[0];
            sourceDropdown.DataSource = Paths.Sources;
        }
        private bool ValidateUrl()
        {
            bool isValid = Uri.TryCreate(Paths.BasePath.Trim('/'), UriKind.Absolute, out Uri uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            if (!isValid)
            {
                leftStatusLabel.Text = "Invalid URL";
                MessageBox.Show("Invalid Base URL! ", "Invalid URL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void searchButton_Click(object sender, EventArgs e) // Search Button
        {
            if (!ValidateUrl()) return;
            try
            {
                leftStatusLabel.Text = "Searching...";
                string request = tagsTextBox.Text.Replace(' ', '+').Replace("*", "%2a");
                if (Transfer.IsAPI)
                {
                    int countContent = GelbooruAPI.GetCountContent(request);
                    if (countContent > 0)
                    {
                        leftStatusLabel.Text = "Search completed";
                        if (MessageBox.Show(countContent + " results found. Open in a browser?", "Searching results", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            Process.Start(Paths.WebRequestPath + request);
                        }
                    }
                    else
                    {
                        leftStatusLabel.Text = "Search completed";
                        MessageBox.Show("Nobody here but us chickens!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else // If parsing method
                {
                    if (GelbooruParser.IsSomethingFound(request))
                    {
                        int countContent = GelbooruParser.GetCountContent(request, GelbooruParser.GetMaxPid(request));
                        if (countContent > 0)
                        {
                            leftStatusLabel.Text = "Search completed";
                            if (MessageBox.Show(countContent + " results found. Open in a browser?", "Searching results", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                Process.Start(Paths.WebRequestPath + request);
                            }
                        }
                        else
                        {
                            leftStatusLabel.Text = "Search completed";
                            MessageBox.Show("Unable to search this deep in temporarily (error on site)", "Search error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        leftStatusLabel.Text = "Search completed";
                        MessageBox.Show("Nobody here but us chickens!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exp)
            {
                string errorBody = exp.Message;
                if (exp is WebException)
                {
                    errorBody += "\n(Is your base url correct?)";
                }
                leftStatusLabel.Text = "Search error";
                MessageBox.Show(errorBody, "Search error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void downloadButton_Click(object sender, EventArgs e) // Download Button
        {
            if (!ValidateUrl()) return;
            try
            {
                string request = tagsTextBox.Text.Replace(' ', '+').Replace("*", "%2a");
                if (Transfer.IsAPI)
                {
                    int countContent = GelbooruAPI.GetCountContent(request);
                    if (countContent > 0)
                    {
                        if (folderBrowserDialog.ShowDialog() != DialogResult.Cancel)
                        {
                            Properties.Settings.Default.Path = folderBrowserDialog.SelectedPath;
                            Properties.Settings.Default.Save();

                            DownloadingForm dlf = new DownloadingForm(countContent);
                            dlf.ShowDialog();

                            if (Transfer.Limit > 0)
                            {
                                leftStatusLabel.Text = "Downloading content...";
                                progressBar.Maximum = Transfer.Limit;

                                var progress = new Progress<int>(s => progressBar.Value = s);
                                var progress2 = new Progress<int>(s => rightStatusLabel.Text = s + " / " + Transfer.Limit);
                                await Task.Factory.StartNew(() => GelbooruAPI.DownloadContent(request, folderBrowserDialog.SelectedPath, progress, progress2, Transfer.Limit), TaskCreationOptions.LongRunning);

                                leftStatusLabel.Text = "Download completed";
                                if (MessageBox.Show("Download completed! Open the folder?", "Download completed", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                {
                                    Process.Start(folderBrowserDialog.SelectedPath);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nobody here but us chickens!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else // If parsing method
                {
                    if (GelbooruParser.IsSomethingFound(request))
                    {
                        if (folderBrowserDialog.ShowDialog() != DialogResult.Cancel)
                        {
                            Properties.Settings.Default.Path = folderBrowserDialog.SelectedPath;
                            Properties.Settings.Default.Save();

                            int countContent = GelbooruParser.GetCountContent(request, GelbooruParser.GetMaxPid(request));
                            DownloadingForm dlf;
                            if (countContent > 0)
                            {
                                dlf = new DownloadingForm(countContent);
                            }
                            else
                            {
                                dlf = new DownloadingForm(11111);
                            }
                            dlf.ShowDialog();

                            if (Transfer.Limit > 0)
                            {
                                leftStatusLabel.Text = "Downloading content...";
                                progressBar.Maximum = Transfer.Limit;

                                var progress = new Progress<int>(s => progressBar.Value = s);
                                var progress2 = new Progress<int>(s => rightStatusLabel.Text = s + " / " + Transfer.Limit);
                                await Task.Factory.StartNew(() => GelbooruParser.DownloadPages(request, folderBrowserDialog.SelectedPath, progress, progress2, Transfer.Limit), TaskCreationOptions.LongRunning);

                                leftStatusLabel.Text = "Download completed";
                                if (MessageBox.Show("Download completed. Open the folder?", "Download completed", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                {
                                    Process.Start(folderBrowserDialog.SelectedPath);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nobody here but us chickens!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exp)
            {
                string errorBody = exp.Message;
                if (exp is WebException)
                {
                    errorBody += "\n(Is your base url correct?)";
                }
                leftStatusLabel.Text = "Download error";
                MessageBox.Show(errorBody, "Download error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutButton_Click(object sender, EventArgs e) // About Button
        {
            MessageBox.Show("Author: r34dlnew, coop152\nVersion: 1.1", "About Gelbooru Downloader", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void searchHelpButton_Click(object sender, EventArgs e) // Help Button
        {
            Process.Start("https://gelbooru.com/index.php?page=wiki&s=view&id=26263");
        }

        private void settingsPictureBox_Click(object sender, EventArgs e) // Settings Button
        {
            SettingsForm sf = new SettingsForm();
            sf.ShowDialog();
        }

        public static bool CheckForInternetConnection(string siteName)
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead(siteName))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        private void modifySourcesButton_Click(object sender, EventArgs e)
        {

        }

        private void sourceDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            Paths.BasePath = Paths.Sources[comboBox.SelectedIndex];
        }

        private void tagsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void infoLabel_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog_HelpRequest(object sender, EventArgs e)
        {

        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void leftStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void rightStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void baseUrlLabel_Click(object sender, EventArgs e)
        {

        }

        private void tagsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}