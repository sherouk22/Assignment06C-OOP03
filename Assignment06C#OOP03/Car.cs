using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06C_OOP03
{
    public class Car
    {
        public int? Id { get; set; }
        public string? Model { get; set; }
        public decimal Speed { get; set; }


        //chain  constructor
        public Car(int? id, string? model, decimal speed)
        {
            Console.WriteLine("constructor 01");
            Id = id;
            Model = model;
            Speed = speed;

        }

        public Car(int? id, string? model) : this(id, model, 180)
        {
            Console.WriteLine("constructor 02");
        }

        public Car(int? id) : this(id, "BMW")
        {

            Console.WriteLine("constructor 03");
        }

        public override string ToString()
        {
            return $"Id = {Id} \n Model = {Model} \n Speed = {Speed}";
        }

    }
}
