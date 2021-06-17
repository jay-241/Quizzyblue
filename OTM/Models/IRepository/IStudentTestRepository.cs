using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OTM.Models
{
    public interface IStudentTestRepository
    {
        public StudentTest AddStudentTest(StudentTest st);
        public StudentTest EditStudentTest(StudentTest st);
        public StudentTest GetStudentTest(int StudentTestId);
        public bool DeleteStudentTest(int StudentTestId);

        public IEnumerable<StudentTest> GetAllStudentTest();

        public IEnumerable<Student> getStudents(int TestId);

        public IEnumerable<Test> getTests(int StudentId);

        public DateTime getAttendedDate(int StudentId,int TestId);
        public int GetResults(int StudentId,int TestId);
    }
}
