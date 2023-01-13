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
        public bool HasTrunk { get; set; } = true;
        public int NumberOfWheels { get; set; } = 4;

        public override void PrintProperties()
        {
            Console.WriteLine($"Do Cars have trunks? {HasTrunk}");
            Console.WriteLine($"How many wheels on a Car? {NumberOfWheels}");
        }

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
