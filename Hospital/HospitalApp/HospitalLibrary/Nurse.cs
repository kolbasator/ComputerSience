using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HospitalLibrary
{
    [Serializable]

    public class Nurse : Employee
    {
        public Nurse(string name, string surname, int idNumber, string password, string username)
            :base(name,surname,idNumber,password,username)
        {
        }
       
    }
}
