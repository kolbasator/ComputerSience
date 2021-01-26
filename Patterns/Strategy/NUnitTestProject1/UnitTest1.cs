using NUnit.Framework;
using Strategy;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StrategyTest()
        {
            Car auto = new Car(4, "Volvo", new PetrolMove());
            Assert.IsTrue(auto.Move()== "����������� �� �������");
            auto.Movable = new ElectricMove();
            Assert.IsTrue(auto.Move() == "����������� �� �������������");

        }
    }
}