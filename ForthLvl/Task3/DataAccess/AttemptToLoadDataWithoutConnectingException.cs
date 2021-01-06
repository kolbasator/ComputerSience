using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class AttemptToLoadDataWithoutConnectingException :Exception
    {

        public string StudentName { get; }

        public AttemptToLoadDataWithoutConnectingException() { }

        public AttemptToLoadDataWithoutConnectingException(string message)
            : base(message) { }

        public AttemptToLoadDataWithoutConnectingException(string message, Exception inner)
            : base(message, inner) { }
    }
}
