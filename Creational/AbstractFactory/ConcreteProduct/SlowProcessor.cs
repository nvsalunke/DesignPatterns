using System;

namespace Creational.AbstractFactory
{
    public class SlowProcessor : IProcessor
    {
        public void Process()
        {
            Console.WriteLine("Data processing will be slow.");
        }
    }
}
