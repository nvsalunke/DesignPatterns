namespace Creational.Builder
{
    public interface IComputer
    {
        void AddCPU(string cpu);
        void AddGPU(string gpu);
        void AddRAM(string ram);
        void AddHDD(string hdd);
        void AddMonitor(string monitor);
        void EanbleTouchscreen(bool enable);
        void DisplayDetails();
        Computer GetComputer();
    }
}