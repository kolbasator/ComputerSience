using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public  class Nokia : IMobilePhone
    {
        public string Call()
        {
            return "Call from nokia";
        }
    }
}
