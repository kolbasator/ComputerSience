using NUnit.Framework;
using Prototype;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CloneTest1()
        {
            var razumovsky = new TerminatorPrototype("Razumovsky R","T800");
            var razumovsky2 = razumovsky.Clone();
            Assert.IsTrue(razumovsky2.Name == "Razumovsky R"&& razumovsky2.Model == "T800");
            razumovsky2.Name = "Musyaka";
            razumovsky2.Model = "Kolbasyaka";
            Assert.IsTrue(razumovsky2.Name == "Musyaka" && razumovsky2.Model == "Kolbasyaka");

        } 
        public void CloneTest2()
        {
            var razumovsky = new TerminatorPrototype("Razumovsky R", "T800");
            razumovsky.Name = "Musyaka";
            razumovsky.Model = "Kolbasyaka";
            var razumovsky2 = razumovsky.Clone();
            Assert.IsTrue(razumovsky2.Name == "Musyaka" && razumovsky2.Model == "Kolbasyaka");
        }
    }
}