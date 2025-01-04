using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssiginment02.Binding
{
    internal class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string address { get; set; }


        public void Fun01()
        {
            Console.WriteLine("I am Employee ");
        }

        public virtual void Fun02()
        {
            Console.WriteLine($"salary = ????");
        }
    }
}
