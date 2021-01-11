using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace HospitalLibrary
{
    public static class Calendar
    {
        public static List<Employee>[] arrayOfLists = new List<Employee>[31];
        public static void SetData()
        {
            for(int u = 1; u < 31; u++)
            {
                arrayOfLists[u] = new List<Employee>();
            }
        }
        
    }
}
