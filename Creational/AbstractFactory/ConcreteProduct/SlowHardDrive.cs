using System;

namespace Creational.AbstractFactory
{
    public class SlowHardDrive : IHardDrive
    {
        public void Store()
        {
            Console.WriteLine("Data storage will be slow.");
        }
    }
}
