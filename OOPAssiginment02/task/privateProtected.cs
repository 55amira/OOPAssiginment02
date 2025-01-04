using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssiginment02.task
{
   

    class Transport
    {
     
        private protected int MaxSpeed { get; set; }

        public Transport(int maxSpeed)
        {
            MaxSpeed = maxSpeed;
        }

        
        private protected void DisplayMaxSpeed()
        {
            Console.WriteLine($"The maximum speed is: {MaxSpeed} km/h");
        }
    }

    

}
