using System.Collections.Generic;
using System.Linq;

public class Fixer
{
    public static List<int> PipeFix(List<int> numbers)
    {
        List<int> fixedNumbers = new List<int>(numbers.Count);
        int a = numbers[0];
        int b = numbers[numbers.Count - 1];
        int i = a;
        while (i <= b)
        {
            fixedNumbers.Add(i);
            i++;
        }
        return fixedNumbers;
    }
}
