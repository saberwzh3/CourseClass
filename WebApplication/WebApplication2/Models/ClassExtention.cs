using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public partial class Classes
    {
        public string TeacherName
        {
            get
            {
                if (!TeacherId.HasValue)
                {
                    return "";
                }
                StuManagementEntities db = new StuManagementEntities();
                var teacher = db.Teachers.Where(t => t.Id == TeacherId.Value).FirstOrDefault();
                if(TeacherId == 0)
                {
                    return "";
                }
                return teacher.Name;
            }
        }
    }
}