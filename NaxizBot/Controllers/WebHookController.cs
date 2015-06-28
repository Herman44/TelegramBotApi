using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.IO;
using TelegramBotApi;
using TelegramBotApi.Requests.Methods;
using TelegramBotApi.Requests.Types;

namespace NaxizBot.Controllers
{
    public class WebHookController : Controller
    {
        // POST: Process
        [HttpPost]
        public ActionResult Process()
        {
            var api = new BotApi(WebConfigurationManager.AppSettings["ApiKey"], Request, Server, Convert.ToBoolean(WebConfigurationManager.AppSettings["DebugMode"]));
            var update = api.ConvertWebhookResponse();

            api.SendMessage(new SendMessageRequest
            {
                ChatId = update.Message.UserChat.Id,
                Text = "Testing..."
            });

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}