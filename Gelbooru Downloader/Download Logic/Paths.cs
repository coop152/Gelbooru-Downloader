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
        //public static string BasePath { get => "https://rule34.xxx/"; }
        public static string BasePath { get; set; } = Settings.Default.BaseURL;
        public static string ApiRequestPath { get => BasePath + "/index.php?page=dapi&s=post&q=index"; }
        public static string WebRequestPath { get => BasePath + "/index.php?page=post&s=list&tags="; }
    }
}
