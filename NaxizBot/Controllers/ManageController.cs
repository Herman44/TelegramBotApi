using TelegramBotApi;
using TelegramBotApi.Requests.Methods;
using TelegramBotApi.Requests.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;
using System.Web.Configuration;

namespace NaxizBot.Controllers
{
    public class ManageController : Controller
    {
        // GET: Manage
        public ActionResult Index()
        {
            return View();
        }

        // GET: SetWebhook
        public JsonResult SetWebhook()
        {
            var api = new BotApi(WebConfigurationManager.AppSettings["ApiKey"], Request, Server, Convert.ToBoolean(WebConfigurationManager.AppSettings["DebugMode"]));

            return Json(api.SetWebhook(new SetWebhookRequest
            {
                Url = "https://exmaple.com/WebHook/Process"
            }), JsonRequestBehavior.AllowGet);
        }
    }
}