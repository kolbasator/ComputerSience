using NUnit.Framework;
using Adapter;
namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        public ITransport Car = new Car();
        public Driver Driver = new Driver();
        public IAnimal Camel = new Camel();

        [Test]
        public void DriverTransportTest()
        {
            string message = Driver.Travel(Car);
            Assert.IsTrue(message.Equals("Car drive"));
        }

        [Test]
        public void DriverCamelTest()
        {
            ITransport camelAdapter = new AdapterToAnimal(Camel);
            string message = Driver.Travel(camelAdapter);
            Assert.IsTrue(message.Equals("Camel move."));
        }
    }
}