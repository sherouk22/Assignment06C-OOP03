using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06C_OOP03.Relationships.Association
{
    public class Teacher
    {
        public string? Name { get; set; }

        public void Teach(Course course)
        {
            Console.WriteLine($"Teacher {Name} Teaches Course {course.Titel}");
        }
    }
}
