using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session__03_OOP.Interfaces
{
    public class Employee : ICloneable, IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Salary { get; set; }
        public Employee()
        {
            
        }
        public Employee(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Salary = employee.Salary;
        }
        public object Clone()
        {
            return new Employee(this);
        }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, Salary= {Salary}";
        }

        public int CompareTo(object? obj)
        {
            Employee employee = obj as Employee;
            if(Salary > employee.Salary)
                return 1;
            else if (Salary < employee.Salary)
                return -1;
            return 0;
        }
    }
}
