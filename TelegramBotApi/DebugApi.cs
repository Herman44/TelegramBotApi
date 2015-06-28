using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace TelegramBotApi
{
    public class DebugApi
    {
        public bool Enabled { get; set; }

        private HttpServerUtilityBase Server { get; set; }
        private string DebugLogPath
        {
            get
            {
                return Path.Combine(Server.MapPath("~"), "TelegramBotApiDebugLog");
            }
        }

        public DebugApi(HttpServerUtilityBase server)
        {
            Server = server;
        }

        public void Log(string name, string data)
        {
            if (!Enabled)
            {
                return;
            }

            File.AppendAllText(DebugLogPath, String.Format("{0}: {1}", name, data));
        }
    }
}