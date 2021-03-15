using System;
using System.Threading.Tasks;
using Creational.AbstractFactory;
using Creational.FactoryMethod;
using Creational.Singleton;

namespace Creational
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Creational Patterns deals with object creation!");
            Console.WriteLine("<----------------------------Singleton---------------------------->");
            Parallel.Invoke(() => { SimpleSingleton simpleSingleton = SimpleSingleton.Instance; },
                            () => { SimpleSingleton simpleSingleton = SimpleSingleton.Instance; });
            Parallel.Invoke(() => { ThreadSafeSingleton threadSafeSingleton = ThreadSafeSingleton.Instance; },
                            () => { ThreadSafeSingleton threadSafeSingleton = ThreadSafeSingleton.Instance; });
            Parallel.Invoke(() => { LazySingleton lazySingleton = LazySingleton.Instance; },
                            () => { LazySingleton lazySingleton = LazySingleton.Instance; });

            Console.WriteLine("<----------------------------Simple Factory---------------------------->");
            SimpleFactory.ICreditCard card = SimpleFactory.CreditCardFactory.GetCreditCard(SimpleFactory.CreditCardType.Platinum);
            Console.WriteLine($"Credit card Type: {card.GetCardType()}");
            Console.WriteLine($"Credit card Limit: {card.GetLimit()}");
            Console.WriteLine($"Credit card AnnualCharges: {card.GetAnnualCharges()}");

            card = SimpleFactory.CreditCardFactory.GetCreditCard(SimpleFactory.CreditCardType.Titanium);
            Console.WriteLine($"Credit card Type: {card.GetCardType()}");
            Console.WriteLine($"Credit card Limit: {card.GetLimit()}");
            Console.WriteLine($"Credit card AnnualCharges: {card.GetAnnualCharges()}");

            Console.WriteLine("<----------------------------Factory Method---------------------------->");
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

            Console.WriteLine("<----------------------------Abstract Factory ---------------------------->");
            ComputerFactory computerFactory = new ComputerFactory(new ExpensiveComputer());
            computerFactory.Assemble();
            computerFactory = new ComputerFactory(new CheapComputer());
            computerFactory.Assemble();
            Console.ReadLine();
        }
    }
}
