namespace Creational.FactoryMethod
{
    public class Platinum : ICreditCard
    {
        public double GetAnnualCharges()
        {
            return 500;
        }

        public double GetLimit()
        {
            return 200000;
        }

        public CreditCardType GetCardType()
        {
            return CreditCardType.Platinum;
        }
    }
}
