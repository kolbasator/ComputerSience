using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Hero : IHero
    {
        public int Lives { get; set; }
        public int Patrons { get; set; }
        public string Shoot()
        {
            string result;
            if (this.Patrons >= 1) { this.Patrons--; result = "Производим выстрел."; }
            else { result="Патронов больше нет"; }
            return result;
        }
        public HeroMemento SaveState()
        { 
          return new HeroMemento(Patrons, Lives);
        }
        public string RestoreState(HeroMemento memento)
        {

            this.Patrons = memento.Patrons;
            this.Lives = memento.Lives;
            return $"Восстановление игры. Параметры: {Patrons} патронов, {Lives} жизней";
        }
    }
}
