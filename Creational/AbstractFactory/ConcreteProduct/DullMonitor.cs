using System;

namespace Creational.AbstractFactory
{
    public class DullMonitor : IMonitor
    {
        public void Display()
        {
            Console.WriteLine("Picture quality will be dull.");
        }
    }
}
