# Discussion Week 7 - Sorting

#### Last updated Spring 2018

## Topics Covered

* Sorting
* Sorting performance
* Simple (but mediocre) sorting algorithms

## Worksheet

You've been given a few unit tests, as well as a static class that purports to implement a `BubbleSort` and `Selection` sort method.
Both of those methods have been stubbed out and you need to fill them in. As well, you should write unit tests for each method.


For reference, I wrote three unit tests for each method. You can feel free to write more, but I would imply that there are at least
two edge cases plus a general case, so three is a good number here.

### Aside: Timeouts

There is an attribute in C# called `Timeout`. It's used to demarcate if a unit test should fail after a certain amount of time. You'll
probably want to use it for your tests, since a poorly written `BubbleSort` or `SelectionSort` can take a very long time (5+ seconds)
to run, or even infinite loop. Read the docs for the relevant parameters.

## Micro-quiz

1. Your friend comes to you and alleges that they've created a sorting algorithm for length `N` lists that runs in `O(log N)` time. Why
do you know that their claim is BS without even having to see their implementation? (30 words max.)

2. Quicksort and selection sort both have `O(N^2)` worst case, so why do we prefer quicksort over the simpler selection sort? (10 words max.)

3. Suppose we are sorting a 7 element array using quicksort. After the first partition, the array looks like this: [2, 5, 1, 9, 12, 11, 10].
What was our pivot? (1 word)
