using System.Collections.Generic;
using NUnit.Framework;

namespace MergeSort.Tests
{
    [TestFixture]
    public class MergeSortSolverTests
    {
        [Test]
        public void Sort_ShouldSort_IfNotEmptyArray()
        {
            var mockedArray = new List<int>() {5, 6, 4, 3};

            var sorted = MergeSortSolver.Sort(mockedArray);

            Assert.IsNotEmpty(sorted);
            Assert.AreEqual(sorted[2], 5);
        }

        [Test]
        public void Sort_ShouldReturnEmptyList_IfEmptyArray()
        {
            var mockedArray = new List<int>();

            var sorted = MergeSortSolver.Sort(mockedArray);

            Assert.IsEmpty(sorted);
        }
    }
}
