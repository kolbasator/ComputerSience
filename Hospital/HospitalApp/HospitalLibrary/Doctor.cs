using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalLibrary
{
    [Serializable]
    public class Doctor : Employee
    {
        private int _gmc;
        public int Gmc { get { return _gmc; } set { _gmc = value; } }
        public Doctor(string name, string surname, int idNumber, string password, string username, int gmc)
            : base(name, surname, idNumber, password, username)
        {
            if (Convert.ToString(gmc).Length != 7)
            {
                throw new WrongLengthGms("Invalid GMS Length! Required length is seven digits");
            }
            else if (Convert.ToString(gmc).Length == 7)
            {
                Gmc = gmc;
            }
        }
        public override string GetData()
        {
            return $"{this.Name},{this.Surname},id-{this.IdNumber},username-{this.Username},password-{this.Password},gmc-{this.Gmc}";
        }
    }
}
