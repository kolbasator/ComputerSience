using System;
using System.Collections.Generic;
using System.Text;

namespace SieveOfEratosthenes
{
    public class SieveOfEratosthenes
    {
        public List<uint> SieveOfEratosthenesAlgorithm(int number)
        {
            var numbers = new List<uint>();
            for (var i = 2u; i < number; i++)
            {
                numbers.Add(i);
            } 
            for (var i = 0; i < numbers.Count; i++)
            {
                for (var j = 2u; j < number; j++)
                {
                    numbers.Remove(numbers[i] * j);
                }
            } 
            return numbers;
        }
    }
}
