using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotApi.Http
{
    public class HttpData
    {
        public HttpData()
        {
            Parameters = new HttpParameterList();
            Files = new HttpFileList();
        }

        public HttpParameterList Parameters { get; set; }
        public HttpFileList Files { get; set; }
    }
}
