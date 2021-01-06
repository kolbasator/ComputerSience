using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ClassLibrary1
{
    public class Database : IDatabase
    {
        private static List<MyList> _databases = new List<MyList>();
        public MyList database = new MyList();
        public Connection connection;
        public void ShowTables()
        {
            #region
            Console.Write("Input password of connection:");
            string password1 = Console.ReadLine();
            if (this.connection.Status == true)
            {
                Console.Write("Input password for database:");
                string password = Console.ReadLine();
                if (password == database.Password)
                {
                    Console.WriteLine("+----------+---------------+---------------+");
                    Console.WriteLine("!Id Number !     Name      !    Lastname   !");
                    for (int i = 1; i < database.Count; i++)
                    {

                        string first = "";
                        string second = "";
                        string third = "";
                        if (database[i].Name.Length < 15)
                        {
                            for (int r = 1; r < 16 - database[i].Name.Length; r++)
                            {
                                second += " ";
                            }
                        }
                        if (database[i].Lastname.Length < 15)
                        {
                            for (int r = 1; r < 16 - database[i].Lastname.Length; r++)
                            {
                                third += " ";
                            }

                        }
                        if (Convert.ToString(database[i].IdNumber).Length < 10)
                        {
                            for (int r = 1; r < 18 - first.Length; r++)
                            {
                                first += " ";
                            }
                        }

                        Console.WriteLine("+----------+---------------+---------------+");
                        Console.WriteLine($"!{database[i].IdNumber}{first}!{database[i].Name}{second}!{database[i].Lastname}{third}!");

                    }

                    Console.WriteLine("+----------+---------------+---------------+");

                }
                else
                {
                    throw new IncorrectPasswordException("Incorect password.");
                }
            }


            #endregion
        }
        public void CreateUser(List<User> database, string name, string Lastname)
        {
            #region
            if (this.connection.Status == true)
            {

                if (name.Length <= 15 && Lastname.Length <= 15)
                {

                    User user = new User(Lastname, name, 0);
                    database.Add(user);
                    database[database.IndexOf(user)].IdNumber = database.IndexOf(user);
                }
                else
                {
                    Console.WriteLine("Invalid lastname or name length");
                }
            }
            else
            {
                Console.WriteLine("Please open connection");
                throw new AttemptToLoadDataWithoutConnectingException();

            }
            #endregion
        }
        public void CreateDatabase(string nameOfNewDatabase, string password)
        {
            #region
            MyList database = new MyList();
            database.Name = nameOfNewDatabase;
            database.Password = password;
            _databases.Add(database);
            #endregion;
        }
        public void Use(string name)
        {
            #region
            database = _databases.FirstOrDefault(x => x.Name == name);
            #endregion
        }
        public void DropDatabase(string name)
        {
            #region
            _databases.Remove(_databases.FirstOrDefault(x => x.Name == name));
            #endregion
        }
        public void ShowDatabases()
        {
            #region
            foreach (MyList database in _databases)
                Console.WriteLine(database.Name);
            #endregion
        }
        public string GetUsersData(string number)
        {
            #region
            if (this.connection.Status == true)
            {
                int i = database[database.IndexOf(database.FirstOrDefault(user => user.IdNumber == Convert.ToInt32(number)))].IdNumber;
                string modifiedIdNumber = Convert.ToString(database[i].IdNumber);
                string modifiedName = database[i].Name;
                string modifiedPassword = database[i].Lastname;

                string first = "";
                string second = "";
                string third = "";
                if (database[i].Name.Length < 15)
                {
                    for (int r = 1; r < 16 - database[i].Name.Length; r++)
                    {
                        second += " ";
                    }
                }
                if (database[i].Lastname.Length < 15)
                {
                    for (int r = 1; r < 16 - database[i].Lastname.Length; r++)
                    {
                        third += " ";
                    }

                }
                if (Convert.ToString(database[i].IdNumber).Length < 10)
                {
                    for (int r = 1; r < 18 - first.Length; r++)
                    {
                        first += " ";
                    }
                }

                Console.WriteLine("+----------+---------------+---------------+");
                Console.WriteLine();
                string info = $"!Id Number !     Name      !    Password   !\n+----------+---------------+---------------+\n!{Convert.ToString(database[i].IdNumber)}{first}!{database[i].Name}{second}!{database[i].Lastname}{third}!\n+----------+---------------+---------------+";
                return info;
            }
            else
            {
                throw new AttemptToLoadDataWithoutConnectingException();
            }
            #endregion
        }
        public void Join(string firstDatabaseName, string secondDatabaseName)
        {
            _databases.FirstOrDefault(x => x.Name == firstDatabaseName).Union(_databases.FirstOrDefault(x => x.Name == secondDatabaseName));
        }

    }
}
