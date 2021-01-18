using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
   abstract class  AbstractCarPrototype
    {
        public int Id { get;  set; }
        public AbstractCarPrototype(int id)
        {
            this.Id = id;
        }
        public abstract AbstractCarPrototype Clone();
    }
}
