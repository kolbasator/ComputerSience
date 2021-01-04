using System;
using System.Collections.Generic;
using System.Text;

namespace Task18
{
    class Engine
    {
        private const int _valueOfLitresInTank= 200;
        private double _fuelQuantity;
        private double _displacement;
        private double _fuelTankCapacity;
        private int _engineCapacity;
        public double Mpg(double millesPerGallons)
        {
            return  3.78541*100 / (1.6093 * millesPerGallons);
        }
        public double Lp(double litresPer100Kilometers)
        {
            return 3.78541 * 100/ (1.6093 * litresPer100Kilometers);
        }
        public Engine(double fuelTankCapacity, double fuel, double displacement,int engineCapacity)
        {
            this._fuelTankCapacity = fuelTankCapacity;
            this._fuelQuantity = fuel;
            this._displacement = displacement;
            this._engineCapacity = engineCapacity;
        }
        public Engine( double fuel, int engineCapacity)
        {
            this._fuelQuantity = fuel;
            this._engineCapacity = engineCapacity;
        }
        public Engine(double fuel, double displacement)
        {
            this._fuelQuantity = fuel;
            this._displacement = displacement;
            this._fuelTankCapacity = _valueOfLitresInTank;
        }
        public void Work()
        {
            if (this._fuelQuantity <= 0)
            {
                Console.WriteLine("Не хватает топлива!");
                Console.WriteLine("Error:not enough fuel");
            }
            else 
            {
                this._fuelQuantity -= (this._displacement / 100) * 4;

            }
        }
        public void Refuel(double howManyFuel)
        {
            if((this._fuelTankCapacity + howManyFuel) < _valueOfLitresInTank)
            {
                this._fuelTankCapacity += howManyFuel;
            }

        }
      
       
    }
}
