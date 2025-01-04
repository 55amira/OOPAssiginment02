using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssiginment02.task
{
    using System;


    class Transports
    {
       
        protected internal int MaxSpeed { get; set; }

        public Transports(int maxSpeed)
        {
            MaxSpeed = maxSpeed;
        }
    }

    
    class Cars : Transport
    {
        public Cars(int maxSpeed) : base(maxSpeed) { }

        public void ShowSpeed()
        {
            Console.WriteLine($"The car's maximum speed is: {MaxSpeed} km/h");
        }
    }

    
   
}
