using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Assignment06C_OOP03.Enums;

namespace Assignment06C_OOP03
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityLevel Security { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

        public Gender Gender { get; set; }

        public Employee(int id, string name, SecurityLevel security, decimal salary, DateTime hireDate, Gender gender)
        {
            Id = id;
            Name = name;
            Security = security;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        public override string ToString()
        {
            return $" Id: {Id} \n Name: {Name} \n Security Level: {Security} \n Salary: {Salary} \n Hire Date: {HireDate.ToShortDateString()} \n Gender: {Gender}";
        }


        //public override string ToString()
        //{
        //    return $"Employee Details:\n" +
        //           $"ID: {Id}\n" +
        //           $"Name: {Name}\n" +
        //           $"Security Level: {Security}\n" +
        //           $"Salary: {String.Format("{0:C}", Salary)}\n" +
        //           $"Hire Date: {HireDate:yyyy-MM-dd}\n" +
        //           $"Gender: {Gender}";
        //}

    }
}