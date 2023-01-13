using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()    
        {  
        
        }

        //Properties
        bool HasTrunk = true;
        int NumberOfWheels = 4;

        public override void DriveAbstract()
        {
            Console.WriteLine($"Sunroof is open and the weather is clear!");
        }

        public override void DriveVirtual()
        {
            base.DriveVirtual();      
        }

    }
}
