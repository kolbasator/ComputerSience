using System;
using ClassLibrary1;
namespace Task42._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Database databases = new Database();
            databases.CreateDatabase("Clients", "razumovsky");
            databases.Use("Clients");
            databases.Connection = new Connection("Razumovsky");
            databases.Connection.Open("Razumovsky");
            databases.CreateUser(databases.Database1, "Musyaka", "Kolbasyaka");
            databases.CreateUser(databases.Database1, "Shrek", "Shrekovich");
            databases.CreateUser(databases.Database1, "Razumovsky", "r");
            databases.CreateUser(databases.Database1, "Petro", "Kolosov");
            databases.CreateUser(databases.Database1, "Dungeon", "Master");
            databases.CreateUser(databases.Database1, "Bill", "Kek");
            databases.CreateUser(databases.Database1, "Julia", "Chebotareva");
            databases.CreateUser(databases.Database1, "Kolbasator", "Kolbasyaka");
            databases.ShowTables();
            Console.WriteLine(databases.GetUsersData("2"));

            databases.Connection.Close("Razumovsky");
            Console.ReadLine();

        }
    }
}
