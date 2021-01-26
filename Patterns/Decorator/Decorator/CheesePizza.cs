using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza p)
        : base(p.Name + ", с сыром", p)
        { }

        public override int GetCost()
        {
            return Pizza.GetCost() + 5;
        }
    }
}
