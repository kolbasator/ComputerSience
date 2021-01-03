using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Person
    {
       private string firstName;
       private string familyName;
       public void IntroduceYourself()
       {
            Console.WriteLine($"My name is \n{this.Name}\n{this.FamilyName}");
       }
       public void SetData(string name,string lastname)
        {
            this.familyName = lastname;
            this.firstName = name;
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
    } 
}
