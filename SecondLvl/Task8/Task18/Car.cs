using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task18
{
    class Car
    {
        private string _brand;
        private string _model;
        private Engine _engine;
        public void Go(double distance)
        {
            while (true)
            {
                Console.WriteLine("Я еду");
                _engine.Work();
                Thread.Sleep(100);
                distance--;
                if(distance==0)
                {
                    Console.WriteLine("Я здесь!");
                    break;
                }

            }
        }
    }
}
