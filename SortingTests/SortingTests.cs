using DiscussionWeek7;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SortingTests
{
    [TestClass]
    public class SortingTests
    {
        [TestMethod]
        public void TrivialListIsSorted() {
            IComparable[] test = { 1 };
            Assert.IsTrue(Sorting.Sorted(test));
        }

        [TestMethod]
        public void SimpleSortedList() {
            IComparable[] test = { 1, 2, 3, 4, 5 };
            Assert.IsTrue(Sorting.Sorted(test));
        }

        [TestMethod]
        public void SimpleSortedListWithDuplicates() {
            IComparable[] test = { 1, 1, 1, 1, 1 };
            Assert.IsTrue(Sorting.Sorted(test));
        }

        [TestMethod]
        public void SimpleUnsortedList() {
            IComparable[] test = { 5, 4, 9, 6, 2 };
            Assert.IsFalse(Sorting.Sorted(test));
        }


        [TestMethod]
        public void RandomUnsortedList() {
            var test = Sorting.MakeRandomUnsortedList();
            Assert.IsFalse(Sorting.Sorted(test));
        }

        [TestMethod, Timeout(1000)]
        public void BubbleSortTrivialTest() {
            var test = Sorting.MakeRandomUnsortedList(1);
            Sorting.BubbleSort(test);
            Assert.IsTrue(Sorting.Sorted(test));
        }

        [TestMethod, Timeout(1000)]
        public void BubbleSortTest() {
            var test = Sorting.MakeRandomUnsortedList(1);
            Sorting.BubbleSort(test);
            Assert.IsTrue(Sorting.Sorted(test));
        }

        [TestMethod, Timeout(1000)]
        public void SelectionSortTrivialTest() {
            var test = Sorting.MakeRandomUnsortedList(1);
            Sorting.SelectionSort(test);
            Assert.IsTrue(Sorting.Sorted(test));
        }

        [TestMethod, Timeout(1000)]
        public void SelectionSortTest() {
            var test = Sorting.MakeRandomUnsortedList();
            Sorting.SelectionSort(test);
            Assert.IsTrue(Sorting.Sorted(test));
        }
    }
}
