using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class CarPrototype : AbstractCarPrototype
    {
        public int Id { get; set; }
        public CarPrototype(int id)
            :base(id)
        {
            this.Id = id;
        }
        public override AbstractCarPrototype Clone()
        {
            return new CarPrototype(this.Id);
        }
    }
}
