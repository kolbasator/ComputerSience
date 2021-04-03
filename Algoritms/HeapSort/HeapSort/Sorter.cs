using System;
using System.Linq;
using System.Collections.Generic;

namespace HeapSort
{
    public class Sorter : ISorter
    {
        public void Swap(List<int> arr,int firstIndex, int secondIndex)
        {
            int first = arr[firstIndex];
            int second = arr[secondIndex];
            arr[firstIndex] = second;
            arr[secondIndex] = first;
        }
        public void Heapify(List<int> arr, int index)
        {
            int maxIndex = index;
            if (2 * index + 1 < arr.Count && arr[2 * index + 1] > arr[maxIndex])
                maxIndex = 2 * index + 1;
            if (2 * index + 2 < arr.Count && arr[2 * index + 2] > arr[maxIndex])
                maxIndex = 2 * index + 2;
            if (maxIndex != index)
            {
                Swap(arr,index, maxIndex);
                Heapify(arr,maxIndex);
            }
        }
        public int ExtractMax(List<int> arr)
        { 
            int output = arr[0];
            arr[0] = arr[arr.Count - 1]; 
            arr.RemoveAt(arr.Count - 1); 
            Heapify(arr,0);
            return output;
        }
        public int[] HeapSort(int[] array)
        {
            var arr = array.ToList();
            int[] result = new int[arr.Count]; 
            for (int i = arr.Count / 2 - 1; i >= 0; i--)
                Heapify(arr,i); 
            while (arr.Count > 0)
            {
                int currentMax = ExtractMax(arr);
                result[arr.Count] = currentMax;
            }
            return result;
        }
    }
}
