using Linq_Lesson.Models;
using Linq_Lesson.Tasks;

namespace Linq_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var accountants = new List<Accountant>
                {
                    new Accountant { Id = 1, Accountantname = "Asadulloh", ProgramLanguageId = 2 },
                    new Accountant { Id = 2, Accountantname = "Ibrohim", ProgramLanguageId = 0 },
                    new Accountant { Id = 3, Accountantname = "OtabekWri", ProgramLanguageId = 1 },
                    new Accountant { Id = 4, Accountantname = "Elyorbek", ProgramLanguageId = 0 },
                    new Accountant { Id = 5, Accountantname = "Tohirjon", ProgramLanguageId = 3 },
                    new Accountant { Id = 6, Accountantname = "Hayotillo", ProgramLanguageId = 2 },
                    new Accountant { Id = 7, Accountantname = "Ozodbek", ProgramLanguageId = 6 },
                    new Accountant { Id = 8, Accountantname = "Abdulloh", ProgramLanguageId = 4 },
                    new Accountant { Id = 9, Accountantname = "Sardorbek", ProgramLanguageId = 0 },
                    new Accountant { Id = 10, Accountantname = "Muhammad", ProgramLanguageId = 5 },
                };      

            var PLanguages = new List<ProgramLanguage>
                {
                    new ProgramLanguage { Id = 1, ProgramLanguageName = "JavaScript" },
                    new ProgramLanguage { Id = 2, ProgramLanguageName = "C#" },
                    new ProgramLanguage { Id = 3, ProgramLanguageName = "C" },
                    new ProgramLanguage { Id = 4, ProgramLanguageName = "Python" },
                    new ProgramLanguage { Id = 5, ProgramLanguageName = "Golang" },
                    new ProgramLanguage { Id = 6, ProgramLanguageName = "C++" }
                };


            //Calling to Functions
            IEnumerable<Accountant> result = Task1.FirstTask(accountants, PLanguages);




        }
    }
}















