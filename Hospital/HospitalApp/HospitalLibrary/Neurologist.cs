using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HospitalLibrary
{
    [Serializable]

  public   class Neurologist : Doctor
    {
        public Neurologist(string name, string surname, int idNumber, string password, string username, int gmc)
            : base(name, surname, idNumber, password, username, gmc)
        {
        }
        public override string GetData()
        {
            return $"{this.Name},{this.Surname},id-{this.IdNumber},username-{this.Username},password-{this.Password},gmc-{this.Gmc},type-{Convert.ToString(GetType())}";
        }
         
    }
}
