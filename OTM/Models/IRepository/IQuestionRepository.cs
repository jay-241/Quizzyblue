using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OTM.Models
{
    public interface IQuestionRepository
    {
        Question GetQuestion(int id);
        Question AddQuestion(Question s);
        Question EditQuestion(Question s);
        Boolean DeleteQuestion(int rollno);
        IEnumerable<Question> GetAllQuestions();
        string GetQuestionBrief(int id);
        int GetQuestionMark(int id);
        string GetQuestionValue(int id);
    }
}
