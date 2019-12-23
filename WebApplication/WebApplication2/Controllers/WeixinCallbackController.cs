using Senparc.Weixin.MP;
using Senparc.Weixin.MP.Entities.Request;
using Senparc.Weixin.MP.MvcExtension;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Common;

namespace WebApplication2.Controllers
{
    public class WeixinCallbackController : Controller
    {
        // GET: WeixinCallback

        public static readonly string Token = ConfigurationManager.AppSettings["WeixinToken"];
        public static readonly string AppId = ConfigurationManager.AppSettings["WeixinAppId"];
        public static readonly string AppSecret = ConfigurationManager.AppSettings["WeixinAppSecret"];

        [ActionName("Index")]
        public ActionResult Get(string signature, string timestamp, string nonce,string echostr)
        {
            if(CheckSignature.Check(signature, timestamp, nonce, Token))
            {
                return Content(echostr);
            }
            else
            {
                return Content("failed:"+ signature + "," + CheckSignature.GetSignature(timestamp, nonce, Token) + "如果你们看见这条信息，表面此URL可以填入微信后台");
            }
        }

        [HttpPost]
        [ActionName("Index")]
        public ActionResult Post(PostModel postModel)
        {
            if(!CheckSignature.Check(postModel.Signature, postModel.Timestamp, postModel.Nonce, Token))
            {
                return Content("参数错误！");
            }
            postModel.Token = Token;
            postModel.EncodingAESKey = AppSecret;
            postModel.AppId = AppId;

            var messageHandler = new CustomMessageHandler(Request.InputStream, postModel);

            messageHandler.Execute();
            return new FixWeixinBugWeixinResult(messageHandler);
        }
    }
}