using NUnit.Framework;
using SingletonPattern;

namespace UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestTimeCreated()
        {
            Singleton obj = Singleton.GetInstance();
            Singleton obj1 = Singleton.GetInstance();
            Assert.IsTrue(obj.TimeCreated==obj1.TimeCreated);
        }


      
    }
}