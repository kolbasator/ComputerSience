using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Car : ICar
    {
       public int Passengers; 
       public string Model;  

        public Car(int num, string model, IMovable mov)
        {
            this.Passengers = num;
            this.Model = model;
            Movable = mov;
        }
        public IMovable Movable {  get; set; }
        public string Move()
        {
             return Movable.Move();
        }
    }
}
