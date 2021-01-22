using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public interface IDriver
    {
        public string Travel(ITransport transport);
    }
}
