using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    class Singleton : ISingleton
    {
        //Одиночка-это паттерн который гарантирует то что в системе будет создан только один подобный обьект .Так же он обеспечивает доступ к этому обьекту.
        //
        private Singleton instance { get; set; }
        private Singleton() 
        {  }
        public  Singleton getInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }

    }
}
