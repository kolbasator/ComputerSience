using NUnit.Framework;
using FluentAssertions;
using ReverseHeapSort;

namespace TDD
{
    public class SortSimpleTest
    {
        [Test]
        public void ReverseHeapSortTest()
        {
            var array = new int[] { 1, 4, 3, 2, 7 };
            var sorter = new Sorter();
            var result = sorter.HeapSort(array);
            result.Should().BeEquivalentTo(new int[] { 7, 4, 3, 2, 1 });
            array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            result = sorter.HeapSort(array);
            result.Should().BeEquivalentTo(new int[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });
        }
    }
}