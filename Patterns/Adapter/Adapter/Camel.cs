using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Camel : IAnimal
    {
        public string Move()
        {
            return "Camel move.";
        }
    }
}
