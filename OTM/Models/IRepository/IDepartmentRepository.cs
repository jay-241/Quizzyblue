using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OTM.Models
{
    public interface IDepartmentRepository
    {
        public int getDepartmentCode(int id);
        public int getDepartmentId(int deptcode);

        public string getDepartmentsname(int id);
        public int getDepartmentId(string sname);

        public string getDepartmentName(int id);

        public IEnumerable<Department> getAllDepartment();

        
    }
}
