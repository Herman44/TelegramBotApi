using Api.Requests.Types.Interfaces;
using TelegramBotApi.Http;

namespace TelegramBotApi.Requests.Types
{
    public class ReplyMarkupRequest : ITypeRequest
    {
        public enum ReplyMarkupTypes
        {
            None,
            ReplyKeyboardMarkup,
            ReplyKeyboardHide,
            ForceReply
        }

        private ForceReplyRequest replyMarkupForceReply;
        private ReplyKeyboardHideRequest replyMarkupReplyKeyboardHide;
        private ReplyKeyboardMarkupRequest replyMarkupReplyKeyboardMarkup;
        private ReplyMarkupTypes replyMarkupType = ReplyMarkupTypes.None;

        public ReplyMarkupTypes ReplyMarkupType
        {
            get { return replyMarkupType; }
        }

        public ReplyKeyboardMarkupRequest ReplyMarkupReplyKeyboardMarkup
        {
            get { return replyMarkupReplyKeyboardMarkup; }
            set
            {
                replyMarkupReplyKeyboardMarkup = value;
                replyMarkupReplyKeyboardHide = null;
                replyMarkupForceReply = null;

                replyMarkupType = value == null ? ReplyMarkupTypes.None : ReplyMarkupTypes.ReplyKeyboardMarkup;
            }
        }

        public ReplyKeyboardHideRequest ReplyMarkupReplyKeyboardHide
        {
            get { return replyMarkupReplyKeyboardHide; }
            set
            {
                replyMarkupReplyKeyboardMarkup = null;
                replyMarkupReplyKeyboardHide = value;
                replyMarkupForceReply = null;

                replyMarkupType = value == null ? ReplyMarkupTypes.None : ReplyMarkupTypes.ReplyKeyboardHide;
            }
        }

        public ForceReplyRequest ReplyMarkupForceReply
        {
            get { return replyMarkupForceReply; }
            set
            {
                replyMarkupReplyKeyboardMarkup = null;
                replyMarkupReplyKeyboardHide = null;
                replyMarkupForceReply = value;

                replyMarkupType = value == null ? ReplyMarkupTypes.None : ReplyMarkupTypes.ForceReply;
            }
        }

        public void Parse(HttpData httpData, string key)
        {
            switch (ReplyMarkupType)
            {
                case ReplyMarkupTypes.ReplyKeyboardMarkup:
                    ReplyMarkupReplyKeyboardMarkup.Parse(httpData, key);
                    break;

                case ReplyMarkupTypes.ReplyKeyboardHide:
                    ReplyMarkupReplyKeyboardHide.Parse(httpData, key);
                    break;

                case ReplyMarkupTypes.ForceReply:
                    ReplyMarkupForceReply.Parse(httpData, key);
                    break;
            }
        }
    }
}