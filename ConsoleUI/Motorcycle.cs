using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public int HowManyGears { get; set; } = 5;

        public override void DriveAbstract()
        {
            Console.WriteLine($"This motorcycle is in gear!");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle does not have a virtual drive method!");
        }
    }
}
