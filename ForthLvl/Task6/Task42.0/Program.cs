using System;
using ClassLibrary1;
using System.Linq;

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
            MyList database = databases.Databases.FirstOrDefault(x => x.Name == "Clients");
            foreach (User user in database.ToList())
                database.Remove(database.FirstOrDefault(v => (v.IdNumber % 2) == 0));
            database[database.IndexOf(database.FirstOrDefault(x => x.Name == "Bill"))].IdNumber = 9;
            database.Sort((x, y) => x.IdNumber.CompareTo(y.IdNumber));
            databases.ShowTables();
            databases.connection.Close("Razumovsky");
            Console.ReadLine();
         
        }
    }
}
