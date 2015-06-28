using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotApi.Http
{
    public class HttpParameterList : List<HttpParameter>
    {
        public void Add(string key, string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                this.Add(new HttpParameter
                {
                    Key = key,
                    Value = value
                });
            }
        }

        public void Add(string key, bool? value)
        {
            if (value.HasValue)
            {
                this.Add(new HttpParameter
                {
                    Key = key,
                    Value = value.Value ? "1" : "0"
                });
            }
        }

        public void Add(string key, int? value)
        {
            if (value.HasValue)
            {
                this.Add(new HttpParameter
                {
                    Key = key,
                    Value = Convert.ToString(value.Value)
                });
            }
        }

        public void Add(string key, float? value)
        {
            if (value.HasValue)
            {
                this.Add(new HttpParameter
                {
                    Key = key,
                    Value = Convert.ToString(value.Value)
                });
            }
        }
    }
}
