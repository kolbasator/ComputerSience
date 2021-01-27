using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class HeroMemento
    {
        public int Patrons { get; set; }
        public int Lives { get; set; }

        public HeroMemento(int patrons, int lives)
        {
            this.Patrons = patrons;
            this.Lives = lives;
        }
    }
}
