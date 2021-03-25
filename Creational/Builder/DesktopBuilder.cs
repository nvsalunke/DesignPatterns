using System;

namespace Creational.Builder
{
    public class DesktopBuilder : IComputer {
        Computer _computer = new Computer();
        public void AddCPU(string cpu){
            _computer.cpu = cpu;
        }
        public void AddGPU(string gpu){
            _computer.gpu=gpu;
        }
        public void AddRAM(string ram){
            _computer.ram=ram;
        }
        public void AddHDD(string hdd){
            _computer.hdd=hdd;
        }
        
        public void AddMonitor(string monitor)
        {
            _computer.monitor = monitor;
        }
        public void EanbleTouchscreen(bool enable)
        {
            return;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"CPU: {_computer.cpu}\t GPU: {_computer.gpu}\t RAM: {_computer.ram}\t HDD: {_computer.hdd}\t  Monitor: {_computer.monitor}");
        }

        public Computer GetComputer()
        {
            return _computer;
        }

    }
}