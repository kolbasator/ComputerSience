using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person me = new Person();
            me.FirstName = "Musyaka";
            me.FamilyName="Chebotarev";
            Console.WriteLine($"My name is \n{me.FirstName}\n{me.FamilyName}");
            Console.ReadLine();
        }
    }
}
