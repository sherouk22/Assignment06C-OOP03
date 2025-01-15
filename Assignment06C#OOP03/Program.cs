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

            Employee employee = new Employee(5,"Ahmed", SecurityLevel.DBA,15000m, new DateTime(2024, 1, 1), Gender.Male );
            Console.WriteLine(employee.ToString());





        }
    }
}
