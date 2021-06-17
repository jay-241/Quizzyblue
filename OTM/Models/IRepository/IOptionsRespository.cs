using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OTM.Models
{
    public interface IOptionsRespository
    { 
        Options GetOption(int id);
        Options AddOption(Options s);
        Options EditOption(Options s);
        Boolean DeleteOption(int rollno);
        IEnumerable<Options> GetAllOptions();
        string GetOptionDescription(int id);
        bool IsOptionCorrect(int id);
        string GetOptionValue(int id);
    }
}
