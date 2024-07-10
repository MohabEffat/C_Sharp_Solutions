using Assignment.Classes;
using Assignment.Enums;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(DateTime.Now)
            {
                Id = 1,
                Name = "Mohab",
                SecurityLevel = 1,
                Salary = 10_000,
                Gender = 'M'
            };
            employee.DisplayDate();

            employee.privilege = Privileges.Developer;

            Console.WriteLine(employee.ToString());
 
            Employee[] employees = new Employee[3];
            employees[0] = new Employee(1, "Mohab", 1, 5000, DateTime.Now, 'M', Privileges.DBA);
            employees[1] = new Employee(2, "Effat", 2, 10000, DateTime.Now, 'M', Privileges.Guest);
            employees[2] = new Employee(2, "Mahmoud", 3, 20000, DateTime.Now, 'M', Privileges.Guest | Privileges.DBA | Privileges.Developer | Privileges.Secretary);

            foreach (var emp in employees)
            {
                Console.WriteLine(emp.ToString());
            }

        }

    }
}
