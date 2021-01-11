using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalLibrary
{
    public class WrongLengthGms : Exception
    {
        public WrongLengthGms() { }

        public WrongLengthGms(string message)
            : base(message) { }

        public WrongLengthGms(string message, Exception inner)
            : base(message, inner) { }

    }
}
