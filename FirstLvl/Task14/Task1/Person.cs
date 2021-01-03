using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Person
    {
        private string firstName;
        private string familyName;
        private string adress;
        public void IntroduceYourself()
        {
            Console.WriteLine($"My name is \n{this.Name}\n{this.FamilyName}\n{this.adress}");
        }
        public void SetData(string name, string lastname,string adress)
        {
            this.familyName = lastname;
            this.firstName = name;
            this.Adress = adress;
        }
        public string Name
        {
            get
            {
                return firstName;
            }


        }
        public string FamilyName
        {
            get
            {
                return familyName;
            }
        }
        public string Adress
        {
            get
            {
                return adress;
            }
            set
            {
                adress = value;
            }
        }
    }
}
