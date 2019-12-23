using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public partial class Student
    {
        public string ClassName
        {
            get
            {
                if(ClassId == 0)
                {
                    return "";
                }
                StuManagementEntities db = new StuManagementEntities();
                var classes = db.Classes.Where(c => c.Id == ClassId).FirstOrDefault();
                if(classes == null)
                {
                    return "";
                }
                return classes.Name;
            }
        }
    }
}