using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public partial class Course
    {
        public string ClassName
        {
            get
            {
                if (!ClassId.HasValue)
                {
                    return "";
                }
                StuManagementEntities db = new StuManagementEntities();
                var classes =  db.Classes.Where(c => c.Id == ClassId.Value).FirstOrDefault();
                if(classes == null)
                {
                    return "";
                }
                return classes.Name;
            }
        }

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
                if (teacher == null)
                {
                    return "";
                }
                return teacher.Name;
            }
        }

        public string SubjectName
        {
            get
            {
                if (!SubjectId.HasValue)
                {
                    return "";
                }
                StuManagementEntities db = new StuManagementEntities();
                var subject = db.Subject.Where(s => s.Id == SubjectId.Value).FirstOrDefault();
                if (subject == null)
                {
                    return "";
                }
                return subject.Name;
            }
        }
    }
}