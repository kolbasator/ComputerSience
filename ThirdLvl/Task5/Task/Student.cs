
using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Student : Person
    {
        public int IdNumber = 5;
        public Student(string name, string lastname) : base(name, lastname)
        {
            base.FirstName = name;
            base.FamilyName = lastname;
        }
        public override string ToString()
        {
            return $"{FirstName}\n{FamilyName}\n{IdNumber}";
        }
    }
}
