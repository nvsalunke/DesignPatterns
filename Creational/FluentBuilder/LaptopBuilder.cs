using System;

namespace Creational.FluentBuilder
{
    public class LaptopBuilder : IComputer {
        Computer _computer = new Computer();
        public IComputer AddCPU(string cpu){
            _computer.cpu = cpu;
            return this;
        }
        public IComputer AddGPU(string gpu){
            _computer.gpu=gpu;
            return this;
        }
        public IComputer AddRAM(string ram){
            _computer.ram=ram;
            return this;
        }
        public IComputer AddHDD(string hdd){
            _computer.hdd=hdd;
            return this;
        }
        
        public IComputer AddMonitor(string monitor)
        {
            return this;
        }

        public IComputer EanbleTouchscreen(bool enable)
        {
            _computer.eanbleTouchscreen = enable;
            return this;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"CPU: {_computer.cpu}\t GPU: {_computer.gpu}\t RAM: {_computer.ram}\t HDD: {_computer.hdd}\t TouchEanabled: {_computer.eanbleTouchscreen}");
        }

        public Computer GetComputer()
        {
            return _computer;
        }

    }
}