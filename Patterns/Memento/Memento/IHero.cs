using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public interface IHero
    {
        public int Patrons { get;  set; }
        public int Lives { get;  set; }
        public string Shoot();
        public HeroMemento SaveState();
        public string  RestoreState(HeroMemento memento);
    }
}
