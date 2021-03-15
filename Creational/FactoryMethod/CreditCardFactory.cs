namespace Creational.FactoryMethod
{
    public abstract class CreditCardFactory
    {
        public ICreditCard GetCreditCard()
        {
            return this.Create();
        }
        protected abstract ICreditCard Create();
    }
}
