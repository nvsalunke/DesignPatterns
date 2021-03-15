namespace Creational.FactoryMethod
{
    public class TitaniumFactory : CreditCardFactory
    {
        protected override ICreditCard Create()
        {
            var card = new Titanium();
            card.SendWelcomeGift();
            return card;
        }
    }
}
