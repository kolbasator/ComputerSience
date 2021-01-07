using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    [Serializable]
    class AnAttemptToCloseAnUnopenedConnectionException : Exception
    {
        public string StudentName { get; }

        public AnAttemptToCloseAnUnopenedConnectionException() { }

        public AnAttemptToCloseAnUnopenedConnectionException(string message)
            : base(message) { }

        public AnAttemptToCloseAnUnopenedConnectionException(string message, Exception inner)
            : base(message, inner) { }


    }
}

