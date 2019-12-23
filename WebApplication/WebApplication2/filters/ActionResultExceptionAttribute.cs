using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.filters
{
    public class ActionResultExceptionAttribute : ActionFilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            if(filterContext.Exception is UnauthorizedException)
            {
                filterContext.Result = new RedirectResult("/Login/Login");
            }
        }
    }
}