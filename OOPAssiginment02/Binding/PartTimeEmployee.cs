﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssiginment02.Binding
{
    internal class PartTimeEmployee : Employee
    {

        public double HoureRate { get; set; }
        public int NumberOfHoure { get; set; }


        public new void Fun01()
        {
            Console.WriteLine("I am Employee ");
        }

        public override void Fun02()
        {
            Console.WriteLine($"salary = {HoureRate * NumberOfHoure}");
        }
    }
}