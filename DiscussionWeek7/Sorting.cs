using System;

namespace DiscussionWeek7
{
    public static class Sorting
    {
        public static void BubbleSort(IComparable[] input) {
            if (input.Length < 2) { return; }

            bool swapped = true;
            while (swapped) {
                swapped = false;
                for (int i = 0, c = input.Length; i < c; i++) {
                    if (input[i - 1].CompareTo(input[i]) <= 0) { continue; }

                    var temp = input[i];
                    input[i] = input[i - 1];
                    input[i - 1] = temp;
                    swapped = true;
                }
            }
        }

        public static void SelectionSort(IComparable[] input) {
            if (input.Length < 2) { return; }

            for (int i = 0, c = input.Length; i < c; i++) {
                // find the minimum
                int minIndex = i;
                for (int j = i + 1; j < c; j++) {
                    if (input[j].CompareTo(input[minIndex]) < 0) {
                        minIndex = j;
                    }
                }
                // swaparoo
                if (minIndex != i) {
                    var temp = input[i];
                    input[i] = input[minIndex];
                    input[minIndex] = temp;
                }
            }
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
