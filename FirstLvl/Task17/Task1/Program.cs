using System;
using System.Collections.Generic;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> contacts = new List<Person>();
            Console.WriteLine("Данная программа создает список контактов ,которые предоставите вы.");
            Console.Write("Введите количество контактов:");
            int ValueOfContacts = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < ValueOfContacts+1; i++)
            {
                Console.WriteLine($"Input name of {i} contact`s:");
                string name = Console.ReadLine();
                Console.WriteLine($"Input lastname of {i} contact`s:");
                string lastname = Console.ReadLine();
                Console.WriteLine($"Input StreetName where live {i} contact:");
                string StreetName = Console.ReadLine();
                Console.WriteLine($"Input number of house ,where live {i} contact:");
                string HouseNumber = Console.ReadLine();
                Console.WriteLine($"Input number of {i} contact`s apartament:");
                string ApartamentNumber = Console.ReadLine();
                Console.WriteLine($"Input post code of city,where live {i} contact:");
                string PostCode = Console.ReadLine();
                Console.WriteLine($"Input name of city,where live {i} contact");
                string City = Console.ReadLine();
                Console.WriteLine($"Input name of Country,where live {i} contact:");
                string Country = Console.ReadLine();
                Person contact = new Person();
                contact.SetData(name, lastname, $"{HouseNumber}/{ApartamentNumber} {StreetName}\n{City}\n{PostCode}\n{Country}");
                contacts.Add(contact);

            }
            bool j = true;
            while (j == true)
            {
                foreach (Person contact in contacts)
                    Console.WriteLine($"{contacts.IndexOf(contact) + 1}. {contact.Name}\n{contact.FamilyName}");
                Console.WriteLine("");
                int index = Convert.ToInt32(Console.ReadLine());
                contacts[index+1].IntroduceYourself();
                Console.ReadLine();
                Console.Clear();
            }
            Console.ReadLine();
        }
    }
}
