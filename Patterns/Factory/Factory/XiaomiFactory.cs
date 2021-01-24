using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class XiaomiFactory : IMobileFactory
    {
        public IMobilePhone MakeMobilePhone()
        {
            return new Xiaomi();
        }
    }
}
