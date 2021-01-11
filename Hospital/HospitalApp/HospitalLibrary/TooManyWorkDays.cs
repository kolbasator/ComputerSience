using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalLibrary
{
    public class TooManyWorkDays : Exception
    {
        public TooManyWorkDays() { }

        public TooManyWorkDays(string message)
            : base(message) { }

        public TooManyWorkDays(string message, Exception inner)
            : base(message, inner) { }
    }
}
