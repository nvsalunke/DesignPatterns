using System;

namespace Creational.AbstractFactory
{
    public class BrightMonitor : IMonitor
    {
        public void Display()
        {
            Console.WriteLine("Picture quality will be bright.");
        }
    }
}
