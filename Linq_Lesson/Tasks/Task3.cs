using Linq_Lesson.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Lesson.Tasks
{
    public class Task3
    {
        public static IEnumerable<IGrouping<string, Accountant>> ThirdTask(List<Accountant> accountants, List<ProgramLanguage> pLanguages)
        {
            var joinedData = accountants
                .Join(pLanguages,
                    accountant => accountant.ProgramLanguageId,
                    language => language.Id,
                    (accountant, language) => new
                    {
                        AccountantId = accountant.Id,
                        AccountantName = accountant.Accountantname,
                        LanguageName = language.ProgramLanguageName
                    });

            var groupedData = joinedData.GroupBy(data => data.LanguageName);

            foreach (var group in groupedData)
            {
                Console.WriteLine($"People who know {group.Key} programming language >>> ");
                foreach (var programmer in group)
                {
                    Console.WriteLine($"Accountant_Id : {programmer.AccountantId} -<<>>- Accountant_Name : {programmer.AccountantName}");
                }
            }

            return (IEnumerable<IGrouping<string, Accountant>>)groupedData;
        }
    }
}
