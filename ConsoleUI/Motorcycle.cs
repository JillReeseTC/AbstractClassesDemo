using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {

            public Motorcycle()
            {

            }
        
            int NumberOfWheels = 2;
            bool HasWindshield = false;

            public override void DriveAbstract()
            {
                Console.WriteLine($"Hope it's not raining!");
            }

            public override void DriveVirtual()
            {
                Console.WriteLine($"Motorcycles feel the wind in their hair virtually!");
            }

    }
}
