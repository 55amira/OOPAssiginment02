using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssiginment02.task
{
    class Vehicle
    {
        protected string Model = "Vehicle";

        protected void Start()
        {
            Console.WriteLine("Vehicle started.");
        }
    }

    class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine($"The {Model} is driving.");
            Start();
        }
    }
}
