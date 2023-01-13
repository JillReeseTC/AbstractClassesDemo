using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var myVehicleList = new List<Vehicle>();   

            var sedan = new Car() 
            { 
                Year = "2020", 
                Make = "Toyota", 
                Model = "Camry"
            };

            myVehicleList.Add(sedan);

            Vehicle coupe = new Car();
            coupe.Year = "2016";
            coupe.Make = "Mazda";
            coupe.Model = "Miata";

            myVehicleList.Add(coupe);

            Vehicle gullwing = new Motorcycle() 
            { 
                Year = "2021", 
                Make = "Honda", 
                Model = "Edge"
            };

            myVehicleList.Add(gullwing);

            var harley = new Motorcycle() 
            { 
                Year = "2023", 
                Make = "Harley", 
                Model = "Brass" 
            };

            myVehicleList.Add(harley);

            foreach (var vehicle in myVehicleList)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
                var vehType = vehicle.GetType().Name;
                Console.WriteLine(vehType);
                

                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
                Console.WriteLine();

            }

            
           
        }
    }
}
