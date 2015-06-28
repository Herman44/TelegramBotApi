using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotApi.Http
{
    public class HttpFile
    {
        public string Key { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] File { get; set; }
    }
}
