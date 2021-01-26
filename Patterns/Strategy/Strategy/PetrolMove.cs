using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class PetrolMove : IMovable
    {
        public string Move()
        {
           return "Перемещение на бензине";
        }
    }
}
