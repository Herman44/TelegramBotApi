using Api.Requests.Types.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramBotApi.Http;

namespace TelegramBotApi.Requests.Types
{
    public class ReplyMarkupRequest : ITypeRequest
    {
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

        public enum ReplyMarkupTypes
        {
            None,
            ReplyKeyboardMarkup,
            ReplyKeyboardHide,
            ForceReply
        }

        private ReplyMarkupTypes replyMarkupType = ReplyMarkupTypes.None;
        public ReplyMarkupTypes ReplyMarkupType
        {
            get
            {
                return replyMarkupType;
            }
        }
        private ReplyKeyboardMarkupRequest replyMarkupReplyKeyboardMarkup;
        public ReplyKeyboardMarkupRequest ReplyMarkupReplyKeyboardMarkup
        {
            get
            {
                return replyMarkupReplyKeyboardMarkup;
            }
            set
            {
                replyMarkupReplyKeyboardMarkup = value;
                replyMarkupReplyKeyboardHide = null;
                replyMarkupForceReply = null;

                replyMarkupType = value == null ? ReplyMarkupTypes.None : ReplyMarkupTypes.ReplyKeyboardMarkup;
            }
        }
        private ReplyKeyboardHideRequest replyMarkupReplyKeyboardHide;
        public ReplyKeyboardHideRequest ReplyMarkupReplyKeyboardHide
        {
            get
            {
                return replyMarkupReplyKeyboardHide;
            }
            set
            {
                replyMarkupReplyKeyboardMarkup = null;
                replyMarkupReplyKeyboardHide = value;
                replyMarkupForceReply = null;

                replyMarkupType = value == null ? ReplyMarkupTypes.None : ReplyMarkupTypes.ReplyKeyboardHide;
            }
        }
        private ForceReplyRequest replyMarkupForceReply;
        public ForceReplyRequest ReplyMarkupForceReply
        {
            get
            {
                return replyMarkupForceReply;
            }
            set
            {
                replyMarkupReplyKeyboardMarkup = null;
                replyMarkupReplyKeyboardHide = null;
                replyMarkupForceReply = value;

                replyMarkupType = value == null ? ReplyMarkupTypes.None : ReplyMarkupTypes.ForceReply;
            }
        }
    }
}
