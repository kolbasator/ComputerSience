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
            databases.connection = new Connection("Razumovsky");
            databases.connection.Open("Razumovsky");
            databases.CreateUser(databases.database, "Musyaka", "Kolbasyaka");
            databases.CreateUser(databases.database, "Shrek", "Shrekovich");
            databases.CreateUser(databases.database, "Razumovsky", "r");
            databases.CreateUser(databases.database, "Petro", "Kolosov");
            databases.CreateUser(databases.database, "Dungeon", "Master");
            databases.CreateUser(databases.database, "Bill", "Kek");
            databases.CreateUser(databases.database, "Julia", "Chebotareva");
            databases.CreateUser(databases.database, "Kolbasator", "Kolbasyaka");
            databases.ShowTables();
            Console.WriteLine(databases.GetUsersData("2"));
            
            databases.connection.Close("Razumovsky");
            Console.ReadLine();
         
        }
    }
}
