using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
   public interface ITerminatorPrototype
    {
        public string Name { get;  set; }
        public string Model { get;  set; }
      
        public  ITerminatorPrototype Clone();
    }
}
