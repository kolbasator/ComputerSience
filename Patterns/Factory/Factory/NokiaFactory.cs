using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class NokiaFactory : IMobileFactory
    {
        public IMobilePhone MakeMobilePhone()
        {
            return new Nokia();
        }
    }
}
