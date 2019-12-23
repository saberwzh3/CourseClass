using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Models.Valiable;

namespace WebApplication2.Controllers
{
    public class LoginController : Controller
    {
        private StuManagementEntities db = new StuManagementEntities();
        // GET: Login
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(Logininput input)
        {
            if (ModelState.IsValid)
            {
                var user = db.Users.FirstOrDefault(u => u.Account == input.Account && u.Passwd == input.Passwd);
                if (user == null)
                {
                    ModelState.AddModelError("Passwd", "用户名不存在或密码错误");
                    return View(input);
                }

                HttpContext.Session?.Add("user", user.Account);

                var cookie = new HttpCookie("user", user.Account.EncryptQueryString())
                {
                    Expires = DateTime.Now.AddHours(3)
                };
                Response.Cookies.Add(cookie);
                return RedirectToAction("Index", "Home");
            }

            return View(input);
        }

        public ActionResult VerificationCode()
        {
            int _verificationLength = 6;
            int _width = 100, _height = 20;
            SizeF _verificationTextSize;
            Bitmap _bitmap = new Bitmap(Server.MapPath("~/Content/Texture.jpg"), true);
            TextureBrush _brush = new TextureBrush(_bitmap);
            //获取验证码
            string _verificationText = Common.Text.VerificationText(_verificationLength);
            //存储验证码
            Session["VerificationCode"] = _verificationText.ToUpper();
            Font _font = new Font("Arial", 14, FontStyle.Bold);
            Bitmap _image = new Bitmap(_width, _height);
            Graphics _g = Graphics.FromImage(_image);
            //清空背景色
            _g.Clear(Color.White);
            //绘制验证码
            _verificationTextSize = _g.MeasureString(_verificationText, _font);
            _g.DrawString(_verificationText, _font, _brush, (_width - _verificationTextSize.Width) / 2, (_height - _verificationTextSize.Height) / 2);
            _image.Save(Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            return null;
        }

    }
}