using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
   public  class User
    {
        private int _idNumber;
        private string _password;
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
               _name = value;
            }
        }
        public string Lastname
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public int IdNumber
        {
            get
            {
                return _idNumber;
            }
            set
            {
                _idNumber = value;
            }
        }
        public User(string password,string name,int idNumber)
        {
            this.Name = name;
            this.Lastname = password;
            this.IdNumber = idNumber;
        }
    }
}
