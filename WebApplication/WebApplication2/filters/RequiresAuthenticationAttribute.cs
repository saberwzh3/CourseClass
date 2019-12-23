using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Models.Valiable;

namespace WebApplication2.filters
{
    public class RequiresAuthenticationAttribute : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session != null)
            {
                var user = filterContext.HttpContext.Session["user"]?.ToString();
                if (!string.IsNullOrWhiteSpace(user))
                {
                    return;
                }
                var cookie = filterContext.HttpContext.Request.Cookies?["user"];
                if (!string.IsNullOrWhiteSpace(cookie?.Value))
                {
                    throw new UnauthorizedException();
                }

                var content = cookie?.Value.DectypeQueryString();

         StuManagementEntities db = new StuManagementEntities();
                if(!db.Users.Any(u=>u.Account == content))
                {
                    throw new UnauthorizedException();
                }

                    /*var user = db.Users.FirstOrDefault(u => u.Account == input.Account && u.Passwd == input.Passwd);*/

            }
        }
    }
}