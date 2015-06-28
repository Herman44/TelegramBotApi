using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotApi
{
    public static class Helpers
    {
        public static DateTime? ToDateTime(this int? timestamp)
        {
            if (timestamp.HasValue)
            {
                return new DateTime(1970, 1, 1).AddSeconds(timestamp.Value);
            }
            else
            {
                return null;
            }
        }
    }
}
