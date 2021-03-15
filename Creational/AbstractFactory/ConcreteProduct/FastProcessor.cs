using System;

namespace Creational.AbstractFactory
{
    public class FastProcessor : IProcessor
    {
        public void Process()
        {
            Console.WriteLine("Data processing will be fast.");
        }
    }
}
