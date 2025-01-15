using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06C_OOP03
{
    public class Child :Perant
    {
        //public int X { get; set; }
        //public int Y { get; set; }
        public int Z { get; set; }

        public Child(int x ,int y , int z) : base (x,y)
        { 
           
            Z = z;
        
        }

        public new int ProductOfNumbers()
        {
            return X * Y * Z;
        }

        public override string ToString()
        {
            return $"X = {X} \n Y = {Y} \n Z = {Z} ";
        }
    }
}
