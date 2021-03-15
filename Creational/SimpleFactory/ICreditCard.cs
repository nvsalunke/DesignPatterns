namespace Creational.SimpleFactory
{
    public interface ICreditCard
    {
        CreditCardType GetCardType();
        double GetLimit();
        double GetAnnualCharges();
    }

    public enum CreditCardType {
        Platinum,
        Titanium
    }
}
