using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class PostalAddress
    {
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


    }
}
