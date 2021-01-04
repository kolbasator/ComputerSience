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
        public Car(string brand,string model,double fuelTankCapacity,double fuelQuantity,double displacement,int engineCapacity)
        {
            this._brand = brand;
            this._model = model;
            this._engine = new Engine(fuelTankCapacity, fuelQuantity,displacement, engineCapacity);
        }
        public Car(string brand, string model, double fuelQuantity, int engineCapacity)
        {
            this._brand = brand;
            this._model = model;
            this._engine = new Engine(fuelQuantity,  engineCapacity);
        }
        public Car(string brand, string model,Engine engine)
        {
            this._brand = brand;
            this._model = model;
            this._engine = engine;
        }
        public void Refuel(double howManyFuel)
        {
            _engine.Refuel(howManyFuel);
        }
    }
}
