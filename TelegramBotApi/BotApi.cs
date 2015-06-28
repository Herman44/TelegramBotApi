using TelegramBotApi.Requests.Methods;
using TelegramBotApi.Requests.Methods.Interfaces;
using TelegramBotApi.Responses.Methods;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web;
using System.IO;
using TelegramBotApi.Responses.Types;
using System.Globalization;

namespace TelegramBotApi
{
    public class BotApi
    {
        private DebugApi debug;
        public DebugApi Debug
        {
            get
            {
                if (debug == null)
                {
                    debug = new DebugApi(Server);
                }
                return debug;
            }
        }
        public int LastUpdateId
        {
            get
            {
                return Convert.ToInt32(File.ReadAllText(LastUpdateIdPath));
            }
            set
            {
                File.WriteAllText(LastUpdateIdPath, Convert.ToString(value));
            }
        }

        private string ApiUrl
        {
            get
            {
                return "https://api.telegram.org";
            }
        }
        private string ApiToken { get; set; }
        private HttpRequestBase Request { get; set; }
        private HttpServerUtilityBase Server { get; set; }
        private string LastUpdateIdPath
        {
            get
            {
                return Path.Combine(Server.MapPath("~"), "TelegramBotApiLastUpdateId");
            }
        }

        public BotApi(string apiToken, HttpRequestBase request, HttpServerUtilityBase server, bool enableDebug = false)
        {
            ApiToken = apiToken;
            Request = request;
            Server = server;

            Debug.Enabled = enableDebug;
        }

        private dynamic ExecuteAction(IMethodRequest request)
        {
            var webRequest = WebRequest.Create(String.Format("{0}/bot{1}/{2}", ApiUrl, ApiToken, request.MethodName));
            webRequest.Method = "POST";
            var boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x", NumberFormatInfo.InvariantInfo);
            webRequest.ContentType = "multipart/form-data; boundary=" + boundary;
            boundary = "--" + boundary;

            using (var requestStream = webRequest.GetRequestStream())
            {
                var options = request.Parse();

                // Write the values
                foreach (var parameter in options.Parameters)
                {
                    var buffer = Encoding.ASCII.GetBytes(boundary + Environment.NewLine);
                    requestStream.Write(buffer, 0, buffer.Length);
                    buffer = Encoding.ASCII.GetBytes(string.Format("Content-Disposition: form-data; name=\"{0}\"{1}{1}", parameter.Key, Environment.NewLine));
                    requestStream.Write(buffer, 0, buffer.Length);
                    buffer = Encoding.UTF8.GetBytes(parameter.Value + Environment.NewLine);
                    requestStream.Write(buffer, 0, buffer.Length);
                }

                // Write the files
                foreach (var file in options.Files)
                {
                    var buffer = Encoding.ASCII.GetBytes(boundary + Environment.NewLine);
                    requestStream.Write(buffer, 0, buffer.Length);
                    buffer = Encoding.UTF8.GetBytes(string.Format("Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"{2}", file.Key, file.FileName, Environment.NewLine));
                    requestStream.Write(buffer, 0, buffer.Length);
                    buffer = Encoding.ASCII.GetBytes(string.Format("Content-Type: {0}{1}{1}", file.ContentType, Environment.NewLine));
                    requestStream.Write(buffer, 0, buffer.Length);
                    new MemoryStream(file.File).CopyTo(requestStream);
                    buffer = Encoding.ASCII.GetBytes(Environment.NewLine);
                    requestStream.Write(buffer, 0, buffer.Length);
                }

                var boundaryBuffer = Encoding.ASCII.GetBytes(boundary + "--");
                requestStream.Write(boundaryBuffer, 0, boundaryBuffer.Length);
            }

            using (var response = webRequest.GetResponse())
            using (var responseStream = response.GetResponseStream())
            using (var stream = new MemoryStream())
            {
                responseStream.CopyTo(stream);
                return Json.Decode(Encoding.UTF8.GetString(stream.ToArray()));
            }
        }

        public GetUpdatesResponse GetUpdates(GetUpdatesRequest getUpdatesRequest)
        {
            return GetUpdatesResponse.Parse(ExecuteAction(getUpdatesRequest));
        }

        public UpdateResponse ConvertWebhookResponse()
        {
            var response = new StreamReader(Request.InputStream).ReadToEnd();
            Debug.Log("ConvertWebHookResponse", response);
            return UpdateResponse.Parse(Json.Decode(response));
        }

        public SetWebhookResponse SetWebhook(SetWebhookRequest setWebhookRequest)
        {
            return SetWebhookResponse.Parse(ExecuteAction(setWebhookRequest));
        }

        public GetMeResponse GetMe(GetMeRequest getMeRequest)
        {
            return GetMeResponse.Parse(ExecuteAction(getMeRequest));
        }

        public SendMessageResponse SendMessage(SendMessageRequest sendMessageRequest)
        {
            return SendMessageResponse.Parse(ExecuteAction(sendMessageRequest));
        }

        public ForwardMessageResponse ForwardMessage(ForwardMessageRequest forwardMessageRequest)
        {
            return ForwardMessageResponse.Parse(ExecuteAction(forwardMessageRequest));
        }

        public SendPhotoResponse SendPhoto(SendPhotoRequest sendPhotoRequest)
        {
            return SendPhotoResponse.Parse(ExecuteAction(sendPhotoRequest));
        }

        public SendAudioResponse SendAudio(SendAudioRequest sendAudioRequest)
        {
            return SendAudioResponse.Parse(ExecuteAction(sendAudioRequest));
        }

        public SendDocumentResponse SendDocument(SendDocumentRequest sendDocumentRequest)
        {
            return SendDocumentResponse.Parse(ExecuteAction(sendDocumentRequest));
        }

        public SendLocationResponse SendLocation(SendLocationRequest sendLocationRequest)
        {
            return SendLocationResponse.Parse(ExecuteAction(sendLocationRequest));
        }

        public SendChatActionResponse SendChatAction(SendChatActionRequest sendChatActionRequest)
        {
            return SendChatActionResponse.Parse(ExecuteAction(sendChatActionRequest));
        }
    }
}
