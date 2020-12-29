using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person me = new Person();
            me.SetData("Musyaka", "Chebotarev","11/1 Tverskaya");
            me.IntroduceYourself();
            Console.ReadLine();
        }
    }
}
