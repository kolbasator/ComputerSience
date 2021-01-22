using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Driver
    {
        public string Travel(ITransport transport)
        {
            return transport.Drive();
        }
    }
}
