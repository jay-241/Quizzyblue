using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OTM.Models
{
    public interface ITestRepository
    {
        public Test AddTest(Test t);
        public Test EditTest(Test t);
        public Test GetTest(int TestId);
        public bool DeleteTest(int TestId);
        public IEnumerable<Test> GetAllTest();
    }
}
