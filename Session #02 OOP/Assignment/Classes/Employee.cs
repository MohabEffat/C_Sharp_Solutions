using Assignment.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Classes
{
    public class Employee : HiringDate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SecurityLevel { get; set; }
        public int Salary { get; set; }
        private char gender;
        public Privileges privilege { get; set; }

        public char Gender
        {
            get { return gender; }
            set
            { 
                if(value == 'M' || value == 'F')
                    gender = value;
                else
                    Console.WriteLine("Invalid Input");
            }
        }
        public Employee(DateTime hireDate) : base(hireDate)
        {

        }
        public Employee(int id, string name, int securityLevel, int salary, DateTime hireDate, char _Gender, Privileges _privilege) : base(hireDate)
        {
            Id = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            Gender = _Gender;
            privilege = _privilege;
        }
        public override string ToString()
        {
            return String.Format("Employee's ID : " + Id + ", Salary is : {0:F2} ", Salary.ToString("C") + ", Name : " + Name + ", Gender : "+ Gender + ", Privilege : " + privilege);
        }
    }
}
