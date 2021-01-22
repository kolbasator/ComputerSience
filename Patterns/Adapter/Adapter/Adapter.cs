using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class AdapterToAnimal : ITransport
    {
        private readonly IAnimal _animal;

        public AdapterToAnimal(IAnimal animal)
        {
            _animal = animal;
        }

        public string Drive()
        {
            return _animal.Move();
        }
    }
}
