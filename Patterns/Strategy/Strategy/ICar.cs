using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface ICar
    {
        public IMovable Movable { get; set; }
        public string Move();
    }
}
