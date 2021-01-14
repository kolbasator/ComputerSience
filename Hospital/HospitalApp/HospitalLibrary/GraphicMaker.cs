using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HospitalLibrary
{
    public static class GraphicMaker
    {
        public static void MakeGraphicForAllEmployees(List<Employee>[] array, int secondDays, List<Employee> employees)
        {
            if (secondDays > 10)
            {
                throw new TooManyWorkDays("Too Many Work Days Exception!");
            }
            for (int o = 0; o < employees.Count; o++)
            {
                int seconDays = secondDays;
                for (int r = 1; r < 31;)
                {
                    
                    secondDays--;
                    if (secondDays == 0)
                    {
                        break;
                    }
                    string type = Convert.ToString(employees[o].GetType());
                   if(array[r].Contains(array[r].FirstOrDefault(e =>Convert.ToString(e.GetType())==type))==false)
                    {
                        employees[o].WorkDayesList[r] = true;
                        array[r].Add(employees[o]);
                        r += 2;
                    }
                    else
                    {
                        r += 3;
                        continue;
                    }

                }
            }
        }
   
        public static void SetGraphicForAllEmployees(  List<Employee> employees)
        {
            for (int o = 0; o < employees.Count; o++)
            {
                for (int r = 1; r < 31; r ++)
                { 
                   if(employees[o].WorkDayesList[r]==true)
                    {
                        employees[o].Graphic += $"{r},";
                    }

                }
            }
        }
    }
}
