using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotApi.Responses.Methods.Interfaces
{
    public interface IMethodResponse
    {
        bool Ok { get; set; }
        int? ErrorCode { get; set; }
        string Description { get; set; }
    }
}
