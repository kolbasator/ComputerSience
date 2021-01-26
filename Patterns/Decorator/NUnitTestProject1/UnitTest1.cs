using NUnit.Framework;
using Decorator;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheesePizzaTest()
        {
            Pizza pizza = new ItalianPizza();
            Assert.IsTrue(pizza.GetCost() == 10 && pizza.Name == "Итальянская пицца");
            pizza = new CheesePizza(pizza);
            Assert.IsTrue(pizza.GetCost() == 15 && pizza.Name == "Итальянская пицца, с сыром");
             
        }
        public void TomtoPizzaTest()
        {
            Pizza pizza = new BulgerianPizza();
            Assert.IsTrue(pizza.GetCost() == 10 && pizza.Name == "Болгарская пицца");
            pizza = new TomatoPizza(pizza);
            Assert.IsTrue(pizza.GetCost() == 13 && pizza.Name == "Болгарская пицца, с томатами");

        }
    }
}