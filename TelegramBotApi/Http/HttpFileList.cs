using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotApi.Http
{
    public class HttpFileList : List<HttpFile>
    {
        public void Add(string key, string extension, byte[] file)
        {
            this.Add(new HttpFile
            {
                Key = key,
                FileName = String.Format("{0}.{1}", Guid.NewGuid().ToString(), extension),
                ContentType = "application/octet-stream",
                File = file
            });
        }
    }
}
