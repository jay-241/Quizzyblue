using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OTM.Models
{
    public interface IStudentRepository
    {
        Student GetStudent(string rollno);
        Student GetStudent(int id);

        //string GetStudentRollNo(int id);
        //int GetStudentId(string rollno);
        Student AddStudent(Student s);

        Student EditStudent(Student s);

        bool DeleteStudent(string rollno);
        bool DeleteStudent(int StudentId);

        IEnumerable<Student> GetAllStudents();
    }
}
