using NUnit.Framework;
using System.Collections.Generic;
using Memento;

namespace NUnitTestProject1
{
    public class Tests
    {
        public HeroMemento PlayerMemento;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NullPatronsTest()
        {
            Hero hero = new Hero();
            hero.Patrons = 0;
            Assert.IsTrue(hero.Shoot()== "Патронов больше нет");
             
        }
        public void MementoTest()
        {
            Hero hero2 = new Hero();
            hero2.Shoot();
            PlayerMemento = hero2.SaveState();
            hero2.RestoreState(PlayerMemento);
            Assert.IsTrue(hero2.Patrons == 9);
        }
    }
}