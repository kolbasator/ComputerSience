using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class CLR : ICLR
    {
        public void Execute()
        {
            Console.WriteLine("Выполнение приложения");
        }
        public void Finish()
        {
            Console.WriteLine("Завершение работы приложения");
        }
    }
}
