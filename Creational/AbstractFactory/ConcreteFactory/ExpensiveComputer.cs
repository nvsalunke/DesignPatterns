namespace Creational.AbstractFactory
{
    class ExpensiveComputer : IComputer
    {
        IProcessor _processor;
        IHardDrive _hardDrive;
        IMonitor _monitor;
        public ExpensiveComputer()
        {
            _processor = new FastProcessor();
            _hardDrive = new FastHardDrive();
            _monitor = new BrightMonitor();
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
