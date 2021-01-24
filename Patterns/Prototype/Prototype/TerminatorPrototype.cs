using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class TerminatorPrototype : ITerminatorPrototype
    {
        public string Name { get;  set; }
        public string Model { get; set; }
        public TerminatorPrototype(string name,string model)
        {
            this.Name = name;
            this.Model = model;
        }
        public ITerminatorPrototype Clone()
        {
            return new TerminatorPrototype(this.Name, this.Model);
        }
    }
}
