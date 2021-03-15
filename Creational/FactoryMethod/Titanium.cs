using System;

namespace Creational.FactoryMethod
{
    public class Titanium : ICreditCard
    {
        public double GetAnnualCharges()
        {
            return 1000;
        }

        public double GetLimit()
        {
            return 500000;
        }

        public CreditCardType GetCardType()
        {
            return CreditCardType.Titanium;
        }

        public void SendWelcomeGift()
        {
            Console.WriteLine("Sent welcome gift");
        }
    }
}
