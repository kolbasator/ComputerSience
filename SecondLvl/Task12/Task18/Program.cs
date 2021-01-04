using System;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Симулятор водилы.");
            Console.Write("Введите брэнд машины >");
            string brand= Console.ReadLine();
            Console.Write("Введите модель машины >");
            string model = Console.ReadLine();
            Console.Write("Введите обьем топливного бака >");
            double fuelTankCapacity = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество топлива (не больше обьема !)>");
            double fuelQuantity = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("Введите литраж >");
            double displacement = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите обьем двигателя >");
            int engineCapacity = Convert.ToInt32(Console.ReadLine());
            Engine engine = new Engine(fuelTankCapacity, fuelQuantity, displacement, engineCapacity);
            Car car = new Car(brand, model, engine);bool i = true;
            while (i)
            {
                Console.WriteLine("Поездка-1");
                Console.WriteLine("Заправка-2");
                string move = Console.ReadLine();
                switch (move)
                {
                    case "1":
                        Console.Write("Введите дистанцию >");
                        int distance = Convert.ToInt32(Console.ReadLine());
                        car.Go(distance);
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    case "2":
                        Console.WriteLine("Заправка.");
                        Console.Write("На сколько литров заполнить бак?(Введите число не больше обьема бака!)>");
                        double howMuchLitres = Convert.ToDouble(Console.ReadLine());
                        car.Refual(howMuchLitres);
                        Console.Clear();
                        continue;
                    default:
                        continue;
                }
            }
            car.Go(10);
            Console.ReadLine();

        }
    }
}
