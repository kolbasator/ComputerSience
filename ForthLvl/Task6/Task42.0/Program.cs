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
            MyList database = databases.Databases.FirstOrDefault(x => x.Name == "Clients");
            foreach (User user in database.ToList())
                database.Remove(database.FirstOrDefault(v => (v.IdNumber % 2) == 0));
            database[database.IndexOf(database.FirstOrDefault(x => x.Name == "Bill"))].IdNumber = 9;
            database.Sort((x, y) => x.IdNumber.CompareTo(y.IdNumber));
            databases.ShowTables();
            databases.Connection.Close("Razumovsky");
            Console.ReadLine();

        }
    }
}
