using System;
using System.Collections.Generic;
using System.Text;

namespace Task18
{
    class Engine
    {
        private const int _valueOfTankInLitres = 200;
        private double _fuelQuantity;
        private double _displacement;
        private double _fuelTankCapacity;
        public double Mpg(double millesPerGallons)
        {
            return  3.78541*100 / (1.6093 * millesPerGallons);
        }
        public double Lp(double litresPer100Kilometers)
        {
            return 3.78541 * 100/ (1.6093 * litresPer100Kilometers);
        }
        public Engine(double fuel,double displacement)
        {
            this._fuelQuantity = fuel;
            this._displacement = displacement;
        }
        public Engine(double fuel, double displacement,double fuelTankCapacity)
        {
            this._fuelQuantity = fuel;
            this._displacement = displacement;
            this._fuelTankCapacity = fuelTankCapacity;
        }
    }
}
