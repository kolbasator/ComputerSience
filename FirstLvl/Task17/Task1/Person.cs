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

        private string StreetName ;
        private string HouseNumber ;
        private string ApartamentNumber ;
        private string PostCode ;
        private string CityName ;
        private string CountryName ;
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
