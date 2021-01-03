
using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Student:Person
    {
      public Student(string name,string lastname) :base(name,lastname)
        {
            base.FirstName = name;
            base.FamilyName = lastname;
        }
    }
}
