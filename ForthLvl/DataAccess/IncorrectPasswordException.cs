using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace ClassLibrary1
{
    [Serializable]
    class IncorrectPasswordException : Exception
    {
        public string StudentName { get; }

        public IncorrectPasswordException() { }

        public IncorrectPasswordException(string message)
            : base(message) { }

        public IncorrectPasswordException(string message, Exception inner)
            : base(message, inner) { }


    }
}
