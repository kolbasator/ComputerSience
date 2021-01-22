using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Car : ITransport
    {
        public string Drive()
        {
            return "Car drive";
        }
    }
}
