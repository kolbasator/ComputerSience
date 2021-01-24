using NUnit.Framework;
using Factory;

namespace UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FactoryTest()
        {

            IMobileFactory factory = new XiaomiFactory();
            var phone = factory.MakeMobilePhone();
            string callMessage = phone.Call();
            Assert.IsTrue(callMessage == "Call from Xiaomi");
            factory = new NokiaFactory();
            phone = factory.MakeMobilePhone();
            callMessage = phone.Call();
            Assert.IsTrue(callMessage == "Call from Nokia");
            factory = new SamsungFactory();
            phone = factory.MakeMobilePhone();
            callMessage = phone.Call();
            Assert.IsTrue(callMessage == "Call from Samsung");
        }
    }
}