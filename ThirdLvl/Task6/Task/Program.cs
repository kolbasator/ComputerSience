using System;
using System.Collections.Generic;
namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Person> list = new List<Person>();
            Person person = new Person("Kirill", "Chebotarev");
            Student student1 = new Student("Razumovsky", "Kolosov");
            Student student2 = new Student("Razumovsky2", "Kolosov");
            list.Add(person);
            list.Add(student1);
            list.Add(student2);
            foreach (Person human in list)
                Console.WriteLine(person.ToString());
            Console.ReadLine();
        }
    }
}
