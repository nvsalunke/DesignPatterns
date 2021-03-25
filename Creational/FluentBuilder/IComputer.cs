namespace Creational.FluentBuilder
{
    public interface IComputer
    {
        IComputer AddCPU(string cpu);
        IComputer AddGPU(string gpu);
        IComputer AddRAM(string ram);
        IComputer AddHDD(string hdd);
        IComputer AddMonitor(string monitor);
        IComputer EanbleTouchscreen(bool enable);
        void DisplayDetails();
        Computer GetComputer();
    }
}