using System.IO;
using System.Web;

namespace TelegramBotApi
{
    public class DebugApi
    {
        public DebugApi(HttpServerUtilityBase server)
        {
            Server = server;
        }

        public bool Enabled { get; set; }
        private HttpServerUtilityBase Server { get; set; }

        private string DebugLogPath
        {
            get { return Path.Combine(Server.MapPath("~"), "TelegramBotApiDebugLog"); }
        }

        public void Log(string name, string data)
        {
            if (!Enabled)
            {
                return;
            }

            File.AppendAllText(DebugLogPath, string.Format("{0}: {1}", name, data));
        }
    }
}