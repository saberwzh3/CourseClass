using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;
using WebApplication2.Models.Valiable;

namespace WebApplication2.Migrations.Seeds
{
    public class UserCreate
    {
        public readonly WebApplication2.Models.StuManagementEntities _content;
        public UserCreate(WebApplication2.Models.StuManagementEntities context)
        {
            _content = context;
        }
        public void Seed()
        {
            var initialUsers = new List<Users>
            {
                new Users
                {
                    Account="admin",
                    Name = "admin",
                    Passwd= "123456"
                }
            };
            foreach (var action in initialUsers)
            {
                if (_content.Users.Any(r => r.Name == action.Name))
                {
                    continue;
                }
                _content.Users.Add(action);
            }
            _content.SaveChanges();

        }
    }
}