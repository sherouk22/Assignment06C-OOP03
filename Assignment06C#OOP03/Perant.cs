using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06C_OOP03
{
    public class Perant
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Perant(int x , int y) 
        { 
            X = x;
            Y = y;
        
        }

        public int ProductOfNumbers()
        {
            return X*Y;
        }

        public override string ToString()
        {
            return $"X = {X} \n Y = {Y} ";
        }

    }
}
