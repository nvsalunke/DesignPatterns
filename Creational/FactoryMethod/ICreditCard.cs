namespace Creational.FactoryMethod
{
    public interface ICreditCard
    {
        CreditCardType GetCardType();
        double GetLimit();
        double GetAnnualCharges();
    }

    public enum CreditCardType
    {
        Platinum,
        Titanium
    }
}
