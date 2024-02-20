using Linq_Lesson.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Lesson.Tasks
{
    public class Task2
    {
        public static IEnumerable<Accountant> SecondTask(List<Accountant> accountants, List<ProgramLanguage> pLanguages)
        {
            var cSharpProgrammers = accountants
                .Where(a => a.ProgramLanguageId == pLanguages.FirstOrDefault(pl => pl.ProgramLanguageName == "C#").Id);

            Console.WriteLine("People who know C# programming language >>> ");
            foreach (var programmer in cSharpProgrammers)
            {
                Console.WriteLine($"Accountant_Id : {programmer.Id} -<<>>- Accountant_Name : {programmer.Accountantname}");
            }

            return cSharpProgrammers;
        }
    }
}
