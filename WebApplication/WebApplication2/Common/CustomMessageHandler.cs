using Senparc.NeuChar.App.AppStore;
using Senparc.NeuChar.Entities;
using Senparc.NeuChar.Entities.Request;
using Senparc.Weixin.MP.Entities;
using Senparc.Weixin.MP.Entities.Request;
using Senparc.Weixin.MP.MessageHandlers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace WebApplication2.Common
{
    public class CustomMessageHandler : MessageHandler<CustomMessageContext>
    {
        public CustomMessageHandler(Stream inputStream, PostModel postModel, int maxRecordCount = 0,
            bool onlyAllowEcryptMessage = false, DeveloperInfo developerInfo = null) : base(inputStream, postModel, maxRecordCount, onlyAllowEcryptMessage, developerInfo)
        {
        }

        public CustomMessageHandler(XDocument requestDocument, PostModel postModel, int maxRecordCount = 0,
            bool onlyAllowEcryptMessage = false, DeveloperInfo developerInfo = null) : base(requestDocument, postModel, maxRecordCount, onlyAllowEcryptMessage, developerInfo)
        {
        }

        public CustomMessageHandler(RequestMessageBase requestMessageBase, PostModel postModel, int maxRecordCount = 0,
            bool onlyAllowEcryptMessage = false, DeveloperInfo developerInfo = null) : base(requestMessageBase, postModel, maxRecordCount, onlyAllowEcryptMessage, developerInfo)
        {
        }

        public override IResponseMessageBase DefaultResponseMessage(IRequestMessageBase requestMessage)
        {

            var responseMessage = this.CreateResponseMessage<ResponseMessageText>();
            responseMessage.Content = "这条消息来自DefaultResponseMessage。";
            return responseMessage;
        }



        public override async Task<IResponseMessageBase> OnTextRequestAsync(RequestMessageText requestMessage)
        {
            var defaultResponseMessage = base.CreateResponseMessage<ResponseMessageText>();

            var requestHandler = requestMessage.StartHandler()
                .Keyword("测试", () =>
                {
                    defaultResponseMessage.Content =
                    @"欢迎光临";
                    return defaultResponseMessage;
                });

            return requestHandler.GetResponseMessage() as IResponseMessageBase;
        }
    }
}