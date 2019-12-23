using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.BLL.Class
{
    public interface IClassRepository
    {
        List<StuManagement> GetManagements(int id);
    }
}
