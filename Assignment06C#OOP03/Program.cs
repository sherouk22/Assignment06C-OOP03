using Assignment06C_OOP03.Enums;
using Assignment06C_OOP03.Relationships.Association;

namespace Assignment06C_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {//Assignment06C#OOP03

            //Part 01
            #region  EX01  all what we have learned in the lecture.

            //Car car = new Car(5, "MBW", 200);
            //Console.WriteLine(car.ToString());

            //Car car = new Car(5, "MBW");
            //Console.WriteLine(car.ToString());

            //Car car = new Car(5);
            //Console.WriteLine(car.ToString());


            #endregion

            #region EX02  all what we have learned in the lecture.

            //Perant perant = new Perant(20,30);
            //int result = perant.ProductOfNumbers();
            //Console.WriteLine(result);

            //Child child = new Child(20, 30 ,10);
            //int result = child.ProductOfNumbers();
            //Console.WriteLine(result);




            #endregion

            #region EX03  all what we have learned in the lecture.
            //Teacher teacher =new Teacher();
            //Course course = new Course();
            //teacher.Name = "Ahmed";
            //course.Titel = "oop";
            //Console.WriteLine(course.Titel);
            //teacher.Teach(course); 
            #endregion


            //Part 02
            #region  Design and implement a Class for the employees in a company:


            //Employee employee = new Employee(5,"Ahmed", SecurityLevel.DBA,15000m, new DateTime(2024, 1, 1),Gender.Male );
            //Console.WriteLine(employee.ToString());

            #endregion

            #region  Develop a Class to represent the Hiring Date Data:


            //HiringDate hiringDate = new HiringDate(7, 7, 2024);
            //Console.WriteLine(hiringDate.ToString());
            // Employee employee = new Employee(5, "Ahmed", SecurityLevel.DBA, 15000m, hiringDate, Gender.Male);
            //Console.WriteLine(employee.ToString());

            #endregion

            #region Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee[]EmpArr;)
            Employee[] EmployeeArr = new Employee[3];
            EmployeeArr[0] = new Employee(1, "Mohamed", SecurityLevel.DBA, 80000.00m, new HiringDate(10, 1, 2024), Gender.Male);
            EmployeeArr[1] = new Employee(2, "Sherouk", SecurityLevel.Guest, 80000.00m, new HiringDate(1, 1, 2024), Gender.Female);
            EmployeeArr[2] = new Employee(3, "Eman", SecurityLevel.DBA | SecurityLevel.Guest | SecurityLevel.Developer | SecurityLevel.Secretary, 80000.00m, new HiringDate(1, 1, 2024), Gender.Female);

            foreach (Employee emp in EmployeeArr)

               Console.WriteLine(emp.ToString());
            #endregion


        }
    }
}
