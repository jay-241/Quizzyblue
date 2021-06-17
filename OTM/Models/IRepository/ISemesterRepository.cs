using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OTM.Models;

namespace OTM
{
    public interface ISemesterRepository
    {
        public int getSemester(int id);
        public int getSemesterId(int sem);
        public IEnumerable<Semester> getAllSemester();
    }
}
