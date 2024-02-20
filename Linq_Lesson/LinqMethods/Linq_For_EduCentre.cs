using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Lesson.LinqMethods
{
    public class LINQForEduCenter
    {
        public List<EduCenter> GetAll()
        {
            List<EduCenter> list = new List<EduCenter>()
            {
                new EduCenter { Id = 1, Name = "Najot Ta'lim", Location = "Chilonzor", Employees  =
                new List<Employee>() {
                    new Employee() { Id = 1, Age = 27, Experience = 4, FirstName = "Akramjon", LastName = "Abduvahobov" },
                    new Employee() { Id = 2, Age = 20, Experience = 3, FirstName = "Abduxoliq", LastName = "Abduxoliqov" },
                    new Employee() { Id = 3, Age = 23, Experience = 1, FirstName = "Muhammad Abdulloh", LastName = "Muhammad Abdullohov" },
                    new Employee() { Id = 4, Age = 40, Experience = 15, FirstName = "Ikromjon", LastName = "Ikromjon" },
                } },
                new EduCenter { Id = 2, Name = "Mohir Dev", Location = "Mirzo Ulug'bek", Employees  =
                new List<Employee>() {
                    new Employee() { Id = 1, Age = 30, Experience = 10, FirstName = "Akramjon Mohirdev", LastName = "Abduvahobov Mohirdev" },
                    new Employee() { Id = 2, Age = 17, Experience = 6, FirstName = "Abduxoliq Mohirdev", LastName = "Abduxoliqov Mohirdev" },
                    new Employee() { Id = 3, Age = 20, Experience = 9, FirstName = "Muhammad Abdulloh Mohirdev", LastName = "Muhammad Abdullohov Mohirdev" },
                    new Employee() { Id = 4, Age = 31, Experience = 2, FirstName = "Ikromjon Mohirdev", LastName = "Ikromjon Mohirdev" },
                } },

                new EduCenter { Id = 3, Name = "IT Tower", Location = "Yunusobod", Employees =
                    new List<Employee>() {
                        new Employee() { Id = 9, Age = 28, Experience = 8, FirstName = "Sarvar", LastName = "Sobirov" },
                        new Employee() { Id = 10, Age = 22, Experience = 2, FirstName = "Javohir", LastName = "Jumayev" },
                    }
                },
                new EduCenter { Id = 4, Name = "Code Academy", Location = "Bektemir", Employees =
                    new List<Employee>() {
                        new Employee() { Id = 11, Age = 35, Experience = 12, FirstName = "Farhod", LastName = "Karimov" },
                        new Employee() { Id = 12, Age = 25, Experience = 5, FirstName = "Anvar", LastName = "Nazarov" },
                    }
                },
                new EduCenter { Id = 5, Name = "DevEd", Location = "Shaykhontohur", Employees =
                    new List<Employee>() {
                        new Employee() { Id = 13, Age = 29, Experience = 7, FirstName = "Umid", LastName = "Rahimov" },
                        new Employee() { Id = 14, Age = 21, Experience = 1, FirstName = "Sobir", LastName = "Aliyev" },
                    }
                },
                new EduCenter { Id = 6, Name = "TechHub", Location = "Olmazor", Employees =
                    new List<Employee>() {
                        new Employee() { Id = 15, Age = 32, Experience = 9, FirstName = "Nodir", LastName = "Yusupov" },
                        new Employee() { Id = 16, Age = 24, Experience = 3, FirstName = "Jamshid", LastName = "Ismoilov" },
                    }
                },
                new EduCenter { Id = 7, Name = "InnovEd", Location = "Mirobod", Employees =
                    new List<Employee>() {
                        new Employee() { Id = 17, Age = 33, Experience = 10, FirstName = "Ilhom", LastName = "Akramov" },
                        new Employee() { Id = 18, Age = 22, Experience = 2, FirstName = "Bekzod", LastName = "Jalilov" },
                    }
                },

                new EduCenter { Id = 7, Name = "InnovEd Third", Location = "Mirobod", Employees =
                    new List<Employee>() {
                        new Employee() { Id = 17, Age = 33, Experience = 10, FirstName = "Ilhom", LastName = "Akramov" },
                        new Employee() { Id = 18, Age = 22, Experience = 2, FirstName = "Bekzod", LastName = "Jalilov" },
                    }
                },
                new EduCenter { Id = 8, Name = "Bright Future", Location = "Sergeli", Employees =
                    new List<Employee>() {
                        new Employee() { Id = 19, Age = 36, Experience = 11, FirstName = "Aziz", LastName = "Aminov" },
                        new Employee() { Id = 20, Age = 23, Experience = 4, FirstName = "Rustam", LastName = "Saidov" },
                    }
                },
                new EduCenter { Id = 9, Name = "NextGen", Location = "Yakkasaroy", Employees =
                    new List<Employee>() {
                        new Employee() { Id = 21, Age = 27, Experience = 7, FirstName = "Shohruh", LastName = "Tursunov" },
                        new Employee() { Id = 22, Age = 19, Experience = 1, FirstName = "Farruh", LastName = "Hamidov" },
                    }
                },
                new EduCenter { Id = 7, Name = "InnovEd Second", Location = "Mirobod", Employees =
                    new List<Employee>() {
                        new Employee() { Id = 17, Age = 33, Experience = 10, FirstName = "Ilhom", LastName = "Akramov" },
                        new Employee() { Id = 18, Age = 22, Experience = 2, FirstName = "Bekzod", LastName = "Jalilov" },
                    }
                },
                new EduCenter { Id = 10, Name = "SkillUp", Location = "Tashkent City", Employees =
                    new List<Employee>() {
                        new Employee() { Id = 23, Age = 34, Experience = 12, FirstName = "Davron", LastName = "Fayziev" },
                        new Employee() { Id = 24, Age = 26, Experience = 6, FirstName = "Siroj", LastName = "Valiyev" },
                    }
                },

            };

            return list;
        }

        public IEnumerable<string> GetAllCenter()
        {
            var centers = GetAll().Select(x => x.Name);

            return centers;
        }

        public IEnumerable<EduCenter> GetCenterByName(string name)
        {
            var centers = GetAll().Select(x => x).Where(z => z.Name == name);

            return centers;
        }

        public IEnumerable<Employee> GetCenterByNameWithExperience()
        {
            var result = GetAll().Where(x => x.Name == "Najot Ta'lim").SelectMany(x => x.Employees).Where(z => z.Experience > 5);

            return result;
        }


        public IEnumerable<Employee> GetCenterByNameWithAgeOrderBy()
        {
            var result = GetAll().SelectMany(x => x.Employees).OrderBy(x => x.Age);

            return result;
        }


        public IEnumerable<Employee> GetCenterByNameWithAgeOrderByDescending()
        {
            var result = GetAll()
                .SelectMany(x => x.Employees)
                .OrderByDescending(x => x.Age);

            return result;
        }

        public IEnumerable<Employee> GetCenterByNameWithAgeOrderByDescendingThenByDescending()
        {
            var result = GetAll()
                .SelectMany(x => x.Employees)
                .OrderByDescending(x => x.Age)
                .ThenByDescending(x => x.FirstName);

            return result;
        }


        /*
        // Join
        var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "John" },
                new Employee { Id = 2, Name = "Alice" },
                new Employee { Id = 3, Name = "Bob" }
            };
        var departments = new List<Department>
            {
                new Department { Id = 1, DName = "HR" },
                new Department { Id = 2, DName = "Finance" }
            };
        var joinedData = employees.Join(departments, emp => emp.Id, dept => dept.Id, (emp, dept) => new { emp.Name, dept.DName });
        Console.WriteLine("Join:");
            foreach (var item in joinedData)
            {
                Console.WriteLine($"{item.Name} - {item.DName}");
            }

        */

    }
}
