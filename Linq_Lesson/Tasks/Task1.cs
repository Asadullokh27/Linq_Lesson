using Linq_Lesson.Models;

namespace Linq_Lesson.Tasks
{
    public class Task1
    {
        public static IEnumerable<Accountant> FirstTask(List<Accountant> accountants, List<ProgramLanguage> pLanguages)
        {
            var programmers = accountants
                .Where(x => x.ProgramLanguageId != 0)
                .Join(pLanguages,
                    accountant => accountant.ProgramLanguageId,
                    language => language.Id,
                    (accountant, language) => new
                    {
                        AccountantId = accountant.Id,
                        AccountantName = accountant.Accountantname,
                        LanguageName = language.ProgramLanguageName
                    });

            Console.WriteLine("People who know a programming language >>> ");
            foreach (var programmer in programmers)
            {
                Console.WriteLine($"Accountant_Id : {programmer.AccountantId} -<<>>- Accountant_Name : {programmer.AccountantName} -<<>>- Language_Name : {programmer.LanguageName}");
            }

            return programmers.Select(p => new Accountant { Id = p.AccountantId, Accountantname = p.AccountantName, ProgramLanguageId = 0 });
        }
    }
}
