using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Client
    {
        public void Operation()
        {

            CarPrototype firstCar = new CarPrototype(9);
            CarPrototype secondCar = firstCar.Clone() as CarPrototype;
            firstCar.Id = 6;
        }
    }
}
