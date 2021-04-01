using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
     public abstract class Vehicle
    {
        public int Year { get; set; } = 2015;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "F-250 King Ranch";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} vehicle is in virtual drive mode!");
        }
    }
}
