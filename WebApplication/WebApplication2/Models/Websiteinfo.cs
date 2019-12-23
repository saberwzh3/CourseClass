using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Websiteinfo
    {
        public const string SiteName = "学生管理系统";

        public List<ActionLink> ActionLinks { get; set; }

        public Websiteinfo()
        {
            ActionLinks = new List<ActionLink>
            {
                new ActionLink{Name="主页",Controller="Home",Action="Index"},
                new ActionLink{Name="关于",Controller="Home",Action="About"},
                new ActionLink{Name="联系方式",Controller="Home",Action="Contact"}
            };
        }
    }
}