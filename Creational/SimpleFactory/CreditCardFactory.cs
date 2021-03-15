using System;

namespace Creational.SimpleFactory
{
    public class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(CreditCardType creditCardType)
        {
            switch (creditCardType)
            {
                case CreditCardType.Platinum: return new Platinum();
                case CreditCardType.Titanium: return new Titanium();
                default: throw new Exception("Type not supported");
            }
        }
    }
}
