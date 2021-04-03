using NUnit.Framework;
using HeapSort;
using FluentAssertions;

namespace TDD
{
    public class SortSimpleTest
    { 
        [Test]
        public void SortTest()
        {
            var array = new int[] { 4, 1, 3, 2, 16, 9, 10, 14, 8, 7 };
            var sorter = new Sorter();
            var result = sorter.HeapSort(array);
            result.Should().BeEquivalentTo(new int[] { 1, 2, 3, 4, 7, 8, 9, 10, 14, 16 });
        }
    }
}