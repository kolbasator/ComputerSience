using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    interface IDatabase
    {
        
        void ShowDatabases();
        void CreateDatabase(string nameOfNewDatabase,string lastname);
        void Use(string name);
        void DropDatabase(string name);
        void ShowTables();
        void CreateUser(List<User> database, string name, string lastname);
        string GetUsersData(string number);
        void Join(string  firstDatabaseName, string secondDatabaseName);
    }
}
