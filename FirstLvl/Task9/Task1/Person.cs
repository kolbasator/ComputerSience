using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Person
    {
       public string FirstName;
       public string FamilyName;
       public void IntroduceYourself()
       {
            Console.WriteLine($"My name is \n{this.FirstName}\n{this.FamilyName}");
       }
    } 
}
