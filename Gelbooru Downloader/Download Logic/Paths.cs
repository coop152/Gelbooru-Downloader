using GelbooruDownloader.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelbooruDownloader.Logic
{
    static class Paths
    {
        public static List<string> Sources { get; set; } // loaded from settings in InitWebsiteDropdown()
        public static string BasePath { get; set; } // the base url associated with the current source
        public static string ApiRequestPath { get => BasePath + "/index.php?page=dapi&s=post&q=index"; } //add format for API
        public static string WebRequestPath { get => BasePath + "/index.php?page=post&s=list&tags="; } //add format for web request
    }
}
