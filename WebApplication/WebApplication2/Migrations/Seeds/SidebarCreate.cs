using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Migrations.Seeds
{
    public class SidebarCreate
    {
        public readonly WebApplication2.Models.StuManagementEntities _content;
        public SidebarCreate(WebApplication2.Models.StuManagementEntities context)
        {
            _content = context;
        }
        public void Seed()
        {
            var initialSidebars = new List<Sidebars>
            {
                new Sidebars
                {
                    Name="班级管理",
                    Controller = "Classes",
                    Action= "Index"
                },
                new Sidebars
                {
                    Name="教师管理",
                    Controller = "Teachers",
                    Action= "Index"
                },

                new Sidebars
                {
                    Name="学生管理",
                    Controller = "Students",
                    Action= "Index"
                }
                ,
                new Sidebars
                {
                    Name="课程科目管理",
                    Controller = "Courses",
                    Action= "Index"
                }
                ,
                new Sidebars
                {
                    Name="课程安排管理",
                    Controller = "Subjects",
                    Action= "Index"
                }
                ,
                new Sidebars
                {
                    Name="课程表管理",
                    Controller = "Subjects",
                    Action= "Index"
                }
                ,
                new Sidebars
                {
                    Name="左部导航栏管理",
                    Controller = "Home",
                    Action= "Index"
                }
                ,
                new Sidebars
                {
                    Name="顶部导航栏管理",
                    Controller = "Actiolinks",
                    Action= "Index"
                }

            };
            foreach (var bar in initialSidebars)
            {
                if (_content.Sidebars.Any(r => r.Name == bar.Name))
                {
                    continue;
                }
                _content.Sidebars.Add(bar);
            }
            _content.SaveChanges();

        }
    }
}