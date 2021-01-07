using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person person = new Person("Kirill", "Chebotarev");
            Student student1 = new Student("Razumovsky", "Kolosov");
            Student student2 = new Student("Razumovsky2", "Kolosov");
            Console.WriteLine(person.ToString());
            Console.WriteLine(student1.ToString());
            Console.WriteLine(student2.ToString());
        }
    }
}
