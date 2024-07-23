using System;
using System.Collections.Generic;
// Done  Create a list of Vehicle called vehicles
namespace ConsoleUI;

public class VehiclesList
{
    public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    
    /*
     * Done  Using a foreach loop iterate through the list and display each of the properties
     */
    public void AllMyVehicles()
    {
        foreach (var ride in Vehicles)
        {
            Console.WriteLine($"My collection includes:\nA {ride.Year} {ride.Make} {ride.Model}");
        }
    }
}

