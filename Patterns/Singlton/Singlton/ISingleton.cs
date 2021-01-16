using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    interface ISingleton
    {
        
        void Singleton() { }

        public Singleton getInstance();
    }
}
