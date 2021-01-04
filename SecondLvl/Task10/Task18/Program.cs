using System;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Engine engine = new Engine(100, 50);
            Engine engine2 = new Engine(100, 50);
            Car car = new Car("Rolls-Royce", " Ghost", engine2);
            car.Go(10);
            Console.ReadLine();

        }
    }
}
