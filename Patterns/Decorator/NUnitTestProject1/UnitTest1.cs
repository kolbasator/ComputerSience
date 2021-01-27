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
            Assert.IsTrue(pizza.GetCost() == 10 && pizza.Name == "Čňŕëü˙íńęŕ˙ ďčööŕ");
            pizza = new CheesePizza(pizza);
            Assert.IsTrue(pizza.GetCost() == 15 && pizza.Name == "Čňŕëü˙íńęŕ˙ ďčööŕ, ń ńűđîě");
             
        }
        public void TomatoPizzaTest()
        {
            Pizza pizza = new BulgerianPizza();
            Assert.IsTrue(pizza.GetCost() == 10 && pizza.Name == "Áîëăŕđńęŕ˙ ďčööŕ");
            pizza = new TomatoPizza(pizza);
            Assert.IsTrue(pizza.GetCost() == 13 && pizza.Name == "Áîëăŕđńęŕ˙ ďčööŕ, ń ňîěŕňŕěč");

        }
    }
}
