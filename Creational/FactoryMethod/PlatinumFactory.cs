namespace Creational.FactoryMethod
{
    public class PlatinumFactory : CreditCardFactory
    {
        protected override ICreditCard Create()
        {
            return new Platinum();
        }
    }
}
