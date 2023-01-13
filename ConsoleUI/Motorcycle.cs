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
        
           public int NumberOfWheels { get; set; } = 2;
           public bool HasWindshield { get; set; } = false;

        public override void PrintProperties()
        {
            Console.WriteLine($"Do Motorcycles have windshields? {HasWindshield}");
            Console.WriteLine($"How many wheels on a Motorcycle? {NumberOfWheels}");
        }

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
