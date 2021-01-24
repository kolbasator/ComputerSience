using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public interface IMobileFactory
    {
        public IMobilePhone MakeMobilePhone();
        
    }
}
