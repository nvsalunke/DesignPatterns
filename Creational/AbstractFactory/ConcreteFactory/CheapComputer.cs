namespace Creational.AbstractFactory
{
    public class CheapComputer : IComputer
    {
        IProcessor _processor;
        IHardDrive _hardDrive;
        IMonitor _monitor;
        public CheapComputer()
        {
            _processor = new SlowProcessor();
            _hardDrive = new SlowHardDrive();
            _monitor = new DullMonitor();
        }
        public IHardDrive GetHardDrive()
        {
            return _hardDrive;
        }

        public IMonitor GetMonitor()
        {
            return _monitor;
        }

        public IProcessor GetProcessor()
        {
            return _processor;
        }
    }
}
