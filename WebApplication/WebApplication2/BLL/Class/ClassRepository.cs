using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.BLL.Class
{
    public class ClassRepository : IClassRepository
    {
        protected StuManagementEntities db = new StuManagementEntities();
        public List<StuManagement> GetManagements(int id)
        {
            var query =
                  from cm in db.Course
                  join c in db.Classes
                      on cm.ClassId equals c.Id
                  join t in db.Teachers
                      on cm.TeacherId equals t.Id
                  where cm.ClassId == id
                  select new StuManagement
                  {
                      ClassName = c.Name,
                      TeacherName = t.Name
                  };
            return query.ToList();
        }
    }
}