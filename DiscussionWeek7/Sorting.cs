using System;

namespace DiscussionWeek7
{
    public static class Sorting
    {
        public static void BubbleSort(IComparable[] input) {
            // TODO fill me in
        }

        public static void SelectionSort(IComparable[] input) {
            // TODO fill me in
        }

        /// <summary>
        /// Is the IComparable[] sorted? Assumes that we care about ascending order only.
        /// </summary>
        public static bool Sorted(IComparable[] input) {
            if (input.Length < 2) { return true; }
            var prev = input[0];
            for (int i = 1, c = input.Length; i < c; i++) {
                if (prev.CompareTo(input[i]) > 0) { return false; }
                prev = input[i];
            }
            return true;
        }


        private static Random rng = new Random();

        /// <summary>
        /// Makes a random unsorted list. System.Random is not very efficient, but that's okay.
        /// </summary>
        public static IComparable[] MakeRandomUnsortedList(int size = 10) {
            var result = MakeRandomList(size);
            if (size < 2) { return result; }
            // while it's nigh impossible that the list will come out perfectly sorted
            // it's important to enforce low-level invariants while unit testing
            while (Sorted(result)) { result = MakeRandomList(size); }
            return result;
        }

        private static IComparable[] MakeRandomList(int size = 10) {
            IComparable[] result = new IComparable[size];
            for (int i = 0; i < size; i++) { result[i] = rng.Next(127); }
            return result;
        }
    }
}
