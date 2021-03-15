namespace Creational.AbstractFactory
{
    public interface IComputer
    {
        IProcessor GetProcessor();
        IMonitor GetMonitor();
        IHardDrive GetHardDrive();
    }
}
