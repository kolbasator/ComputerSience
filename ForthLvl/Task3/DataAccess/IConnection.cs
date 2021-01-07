using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    interface IConnection
    {
        void Open(string password);
        void Close(string password);
    }
}
