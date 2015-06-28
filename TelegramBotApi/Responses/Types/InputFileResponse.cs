using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotApi.Responses.Types
{
    public class InputFileResponse 
    {
        public static InputFileResponse Parse(dynamic data)
        {
            if (data == null)
            {
                return null;
            }

            return new InputFileResponse
            {

            };
        }
    }
}
