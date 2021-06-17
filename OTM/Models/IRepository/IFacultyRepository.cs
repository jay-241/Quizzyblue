using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OTM.Models
{
    public interface IFacultyRepository
    {
        Faculty GetFaculty(string rollno);
        Faculty GetFaculty(int id);

        
        int  GetFacultyId(string rollno);
        Faculty AddFaculty(Faculty s);

        Faculty EditFaculty(Faculty s);

        Boolean DeleteFaculty(string rollno);
        Boolean DeleteFaculty(int rollno);

        IEnumerable<Faculty> GetAllFaculties();
    }
}
