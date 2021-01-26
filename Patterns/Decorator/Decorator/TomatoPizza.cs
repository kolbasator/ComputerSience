using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza p)
    : base(p.Name + ", с томатами", p)
        { }

        public override int GetCost()
        {
            return Pizza.GetCost() + 3;
        }
    }
}
