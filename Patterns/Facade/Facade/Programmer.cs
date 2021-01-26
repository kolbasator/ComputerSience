using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Programmer :  IProgrammer
    {
        public void CreateApplication(VisualStudioFacade facade)
        {
            facade.Start();
            facade.Stop();
        }
    }
}
