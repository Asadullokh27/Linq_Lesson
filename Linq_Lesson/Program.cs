//List<int> numbers = new List<int>
//{
//    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
//};


//var result = numbers;


namespace Linq_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Join
            var employees = new List<Employee>
                {
                    new Employee { Id = 1, EName = "John", DepartmentId = 1 },
                    new Employee { Id = 2, EName = "Alice", DepartmentId = 1 },
                    new Employee { Id = 3, EName = "Bob", DepartmentId = 2 },
                    new Employee { Id = 4, EName = "Jack", DepartmentId = 1 },
                    new Employee { Id = 5, EName = "Toms", DepartmentId = 2 },
                    new Employee { Id = 6, EName = "Ron", DepartmentId = 1 },
                    new Employee { Id = 7, EName = "Ram", DepartmentId = 2 },
                    new Employee { Id = 8, EName = "Devid", DepartmentId = 2 },
                };

            var departments = new List<Department>
                {
                    new Department { Id = 1, DName = "HR" },
                    new Department { Id = 2, DName = "Programming" }
                };






            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            // factorial
            var factorial = employees.GroupBy(x => x.DepartmentId == 1 ? "HR" : "Programming");

            foreach (var factor in factorial)
            {
                Console.WriteLine($"Key: {factor.Key}, EmployeeName: {string.Join(", ", factor.Select(x => x.EName))}");
            }


            var result = employees.ToLookup(x => x.DepartmentId == 1 ? "HR" : "Programming");











            Console.WriteLine("Join:");





        }
    }

    class Employee
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string EName { get; set; }
    }

    class Department
    {
        public int Id { get; set; }
        public string DName { get; set; }
    }

    class EmployeeDepartment
    {
        public string EmployeeName { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
