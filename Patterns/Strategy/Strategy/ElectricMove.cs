using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ElectricMove : IMovable
    {
        public string Move()
        {
           return "Перемещение на электричестве";
        }
    }
}
