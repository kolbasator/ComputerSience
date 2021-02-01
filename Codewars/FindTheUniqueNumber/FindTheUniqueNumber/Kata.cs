using System;
using System.Collections.Generic; 
using System.Linq;

public class Kata
{
    public static int GetUnique(IEnumerable<int> numbers)
    {
        int unique; 
        bool flag;
        int count = 0;
        foreach(int number in numbers)
            if( number  == numbers.Max())
            {
                count++;
            }
        if (count > 1) { flag = true; }
        else { flag = false; }
        if (flag)
            unique = numbers.Min();
        else 
            unique = numbers.Max();
        return unique;
    }
}