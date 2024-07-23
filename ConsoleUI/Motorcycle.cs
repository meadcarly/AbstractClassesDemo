using System;

namespace ConsoleUI;
/*
 * Done  Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
 * Done  Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
 * Done  Provide the implementations for the abstract methods
 * Done  Only in the Motorcycle class will you override the virtual drive method
 */
public class Motorcycle : Vehicle
{
    public bool HasSideCart { get; set; }
    
    public override void DriveAbstract()
    {
        Console.WriteLine("Turns by leaning and handlebars use.");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine("Handles exceptionally well for experienced motorists!");
    }
}