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

        private string StreetName = "Tverskaya";
        private string HouseNumber = "11";
        private string ApartamentNumber = "1";
        private string PostCode = "470000";
        private string CityName = "Moscow";
        private string CountryName = "Russia";
        public string GetDataInPostalFormat
        {
            get
            {
                return $"{HouseNumber}/{ApartamentNumber} {StreetName}\n{CityName}\n{PostCode}\n{CountryName}";
            }
        }
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
