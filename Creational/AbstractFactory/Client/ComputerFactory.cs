namespace Creational.AbstractFactory
{
    public class ComputerFactory
    {
        IComputer _computer;
        public ComputerFactory(IComputer computer)
        {
            _computer = computer;
        }

        public void Assemble() {
            IProcessor processor = _computer.GetProcessor();
            IHardDrive hardDrive = _computer.GetHardDrive();
            IMonitor monitor= _computer.GetMonitor();

            processor.Process();
            hardDrive.Store();
            monitor.Display();
        }
    }
}
