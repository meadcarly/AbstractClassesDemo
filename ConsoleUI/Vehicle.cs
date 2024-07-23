using System;
using Microsoft.VisualBasic;

namespace ConsoleUI;
/*
 * Done  Create an abstract class called Vehicle
 * Done  The vehicle class shall have three string properties: Year, Make, and Model
 * Done  Set the defaults of the properties to something generic in the Vehicle class
 * Done  Vehicle class shall have an abstract method called DriveAbstract with no implementation.
 * Done  Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
 */
public abstract class Vehicle
{
 public string Year { get; set; } = "2021";
 public string Make { get; set; } = "Kia";
 public string Model { get; set; } = "Forte";
 

 public abstract void DriveAbstract();

 public virtual void DriveVirtual()
 {
  Console.WriteLine("Drives well for any motorist.");
 }
}