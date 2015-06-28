using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramBotApi.Http;

namespace Api.Requests.Types.Interfaces
{
    public interface ITypeRequest
    {
        void Parse(HttpData httpData, string key);
    }
}
