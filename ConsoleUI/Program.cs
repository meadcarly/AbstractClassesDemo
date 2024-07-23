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
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /* Done!
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but
             * use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */
            var vehicleList = new VehiclesList();
            
            var ferrari = new Car()
            {
             Year = "2024",
             Make = "Ferrari",
             Model = "Roma",
             HasTrunk = true,
            };
            vehicleList.Vehicles.Add(ferrari);
     
            var kawasaki = new Motorcycle()
            {
             Year = "2021",
             Make = "Kawasaki",
             Model = "Ninja",
             HasSideCart = true,
            };
            vehicleList.Vehicles.Add(kawasaki);

            Vehicle monsterTruck = new Car()
            {
             Year = "2023",
             Make = "Dodge",
             Model = "Ram"
            };
            vehicleList.Vehicles.Add(monsterTruck);

            Vehicle toyota = new Car()
            {
             Year = "2022",
             Make = "Toyota",
             Model = "Camry",
            };
            vehicleList.Vehicles.Add(toyota);
            
            
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */
            vehicleList.AllMyVehicles();

            // Call each of the drive methods for one car and one motorcycle
            ferrari.DriveVirtual();
            ferrari.DriveAbstract();
            
            kawasaki.DriveVirtual();
            kawasaki.DriveAbstract();

            #endregion

            Console.WriteLine("Press any button to continue");
            Console.ReadLine();
        }
    }
}
