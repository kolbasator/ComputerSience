using System;
using System.Linq;
using System.Collections.Generic;
namespace HospitalLibrary
{
    [Serializable]

    public class Employee
    {
       
        private string _name;
        private string _surname;
        private int _idNumber;
        private string _userName;
        private string _password;
        public string Name { get { return _name; } set { _name = value; } }
        public string Surname { get { return _surname; } set { _surname = value; } }
        public int IdNumber { get { return _idNumber; } set { _idNumber = value; } }
        public string Username { get { return _userName; } set { _userName = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public Employee(string name, string surname, int idNumber, string password, string username)
        {
            this.Name = name;
            this.IdNumber = idNumber;
            this.Surname = surname;
            this.Password = password;
            this.Username = username;
        }
        public virtual string GetData()
        {
            return $"{this._name},{this._surname},id-{this._idNumber},username-{this._userName},password-{this._password}";
        }
        public bool[] WorkDayesList = new bool[31];
       
        public string Graphic = "";
       
        public string GetInfo()
        {
            return $"{this.Name},{this.Surname},{Convert.ToString(this.GetType().Name)}, Work dayes-{this.Graphic}\n\n";
        }

    }
}
