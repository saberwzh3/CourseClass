using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Migrations.Seeds
{
    public class ActionLinkCreate
    {
        public readonly WebApplication2.Models.StuManagementEntities _content;
        public ActionLinkCreate(WebApplication2.Models.StuManagementEntities context)
        {
            _content = context;
        }
        public void Seed()
        {
            var initialActiolink = new List<Actiolink>
            {
                new Actiolink
                {
                    Name="主页",
                    Controller = "Home",
                    Action= "Index"
                }
            };
            foreach(var action in initialActiolink)
            {
                if(_content.Actiolink.Any(r=>r.Name == action.Name))
                {
                    continue;
                }
                _content.Actiolink.Add(action);
            }
            _content.SaveChanges();

        }
    }
}