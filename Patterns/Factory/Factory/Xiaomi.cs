using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
   public class Xiaomi : IMobilePhone
    {
        public string Call()
        {
            return "Call from Xiaomi";
        }
    }
}
