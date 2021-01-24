using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class Singleton  
    {
        //Одиночка-это паттерн который гарантирует то что в системе будет создан только один подобный обьект .Так же он обеспечивает доступ к этому обьекту.
        //
        private static Singleton instance { get; set; }
        public DateTime TimeCreated { get; }
        private Singleton()
        {
            TimeCreated = DateTime.Now;
        }
        public static Singleton GetInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }

    }
}
