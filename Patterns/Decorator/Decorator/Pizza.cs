using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public Pizza(string name) 
        {
            this.Name = name;
        }
        public abstract int GetCost();
    }
}
