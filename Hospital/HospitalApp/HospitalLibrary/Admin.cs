using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalLibrary
{
    [Serializable]
    public class Admin : Employee
    {
        public Admin(string name, string surname, int idNumber, string password, string username)
         : base(name, surname, idNumber, password, username)
        {
        }
    }
}
