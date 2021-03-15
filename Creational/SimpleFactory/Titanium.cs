namespace Creational.SimpleFactory
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
    }
}
