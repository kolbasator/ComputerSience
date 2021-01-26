using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class PizzaDecorator : Pizza
    {
        public Pizza Pizza;
        public PizzaDecorator(string name, Pizza pizza) : base(name)
        {
            this.Pizza = pizza;
        }

    }
}
