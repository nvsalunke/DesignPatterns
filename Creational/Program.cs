using System;
using System.Threading.Tasks;
using Creational.AbstractFactory;
using Creational.Builder;
using Creational.FactoryMethod;
using Creational.FluentBuilder;
using Creational.Singleton;

namespace Creational
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Creational Patterns deals with object creation!");
            Console.WriteLine("<---------------------------- Singleton ---------------------------->");
            Parallel.Invoke(() => { SimpleSingleton simpleSingleton = SimpleSingleton.Instance; },
                            () => { SimpleSingleton simpleSingleton = SimpleSingleton.Instance; });
            Parallel.Invoke(() => { ThreadSafeSingleton threadSafeSingleton = ThreadSafeSingleton.Instance; },
                            () => { ThreadSafeSingleton threadSafeSingleton = ThreadSafeSingleton.Instance; });
            Parallel.Invoke(() => { LazySingleton lazySingleton = LazySingleton.Instance; },
                            () => { LazySingleton lazySingleton = LazySingleton.Instance; });

            Console.WriteLine("<---------------------------- Simple Factory ---------------------------->");
            SimpleFactory.ICreditCard card = SimpleFactory.CreditCardFactory.GetCreditCard(SimpleFactory.CreditCardType.Platinum);
            Console.WriteLine($"Credit card Type: {card.GetCardType()}");
            Console.WriteLine($"Credit card Limit: {card.GetLimit()}");
            Console.WriteLine($"Credit card AnnualCharges: {card.GetAnnualCharges()}");

            card = SimpleFactory.CreditCardFactory.GetCreditCard(SimpleFactory.CreditCardType.Titanium);
            Console.WriteLine($"Credit card Type: {card.GetCardType()}");
            Console.WriteLine($"Credit card Limit: {card.GetLimit()}");
            Console.WriteLine($"Credit card AnnualCharges: {card.GetAnnualCharges()}");

            Console.WriteLine("<---------------------------- Factory Method ---------------------------->");
            FactoryMethod.CreditCardFactory creditCardFactory = new PlatinumFactory();
            FactoryMethod.ICreditCard creditCard = creditCardFactory.GetCreditCard();
            Console.WriteLine($"Credit card Type: {creditCard.GetCardType()}");
            Console.WriteLine($"Credit card Limit: {creditCard.GetLimit()}");
            Console.WriteLine($"Credit card AnnualCharges: {creditCard.GetAnnualCharges()}");

            creditCardFactory = new TitaniumFactory();
            creditCard = creditCardFactory.GetCreditCard();
            Console.WriteLine($"Credit card Type: {creditCard.GetCardType()}");
            Console.WriteLine($"Credit card Limit: {creditCard.GetLimit()}");
            Console.WriteLine($"Credit card AnnualCharges: {creditCard.GetAnnualCharges()}");

            Console.WriteLine("<---------------------------- Abstract Factory ---------------------------->");
            ComputerFactory computerFactory = new ComputerFactory(new ExpensiveComputer());
            computerFactory.Assemble();
            computerFactory = new ComputerFactory(new CheapComputer());
            computerFactory.Assemble();

            Console.WriteLine("<---------------------------- Builder ---------------------------->");
            Builder.IComputer computer = new Builder.LaptopBuilder();
            computer.AddCPU("Intel I3");
            computer.AddGPU("AMD Rideon");
            computer.AddRAM("8 GB");
            computer.AddHDD("SATA 500 GB");
            computer.EanbleTouchscreen(true);
            computer.DisplayDetails();

            computer = new Builder.DesktopBuilder();
            computer.AddCPU("Intel I5");
            computer.AddGPU("NVidea");
            computer.AddRAM("16 GB");
            computer.AddHDD("SATA 1 TB");
            computer.AddMonitor("Full HD");
            computer.DisplayDetails();

             Console.WriteLine("<---------------------------- Fluent Builder ---------------------------->");
            FluentBuilder.IComputer computer1 = new FluentBuilder.LaptopBuilder();
            computer1.AddCPU("Intel I3")
            .AddGPU("AMD Rideon")
            .AddRAM("8 GB")
            .AddHDD("SATA 500 GB")
            .EanbleTouchscreen(true)
            .DisplayDetails();

            computer1 = new FluentBuilder.DesktopBuilder();
            computer1.AddCPU("Intel I5")
            .AddGPU("NVidea")
            .AddRAM("16 GB")
            .AddHDD("SATA 1 TB")
            .AddMonitor("Full HD")
            .DisplayDetails();

            Console.ReadLine();

        }
    }
}
