using System;

namespace Creational.AbstractFactory
{
    public class FastHardDrive : IHardDrive
    {
        public void Store()
        {
            Console.WriteLine("Data storage will be fast.");
        }
    }
}
