using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramBotApi.Http;

namespace TelegramBotApi.Requests.Methods.Interfaces
{
    public interface IMethodRequest
    {
        string MethodName { get; }

        HttpData Parse();
    }
}
