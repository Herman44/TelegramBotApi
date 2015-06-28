using System;
using System.Collections.Generic;

namespace TelegramBotApi.Http
{
    public class HttpFileList : List<HttpFile>
    {
        public void Add(string key, string extension, byte[] file)
        {
            Add(new HttpFile
            {
                Key = key,
                FileName = string.Format("{0}.{1}", Guid.NewGuid(), extension),
                ContentType = "application/octet-stream",
                File = file
            });
        }
    }
}