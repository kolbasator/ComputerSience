using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class SamsungFactory : IMobileFactory
    {
        public IMobilePhone MakeMobilePhone()
        {
            return new Samsung();
        }
    }
}
