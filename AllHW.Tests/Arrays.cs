using NUnit.Framework;
using Tasks;

namespace Tasks.Tests
{
    public class Arrays
    {
        [TestCase(new int[] {-3, 3, 1, 9, 6}, -3)]
        [TestCase(new int[] {-3, -323, -1, 0, 6}, -323)]
        [TestCase(new int[] {0, 377, 1, 0, 6}, 0)]
        static public void findMinElem(int[] A, int expected)
        {
            int actual = Tasks.Arrays.findMinElem(A);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { -3, 3, 1, 9, 6 }, 9)]
        [TestCase(new int[] { -3, -323, -1, 0, 6 }, 6)]
        [TestCase(new int[] { 0, 377, 1, 0, 6 }, 377)]
        static public void findMaxElem(int[] A, int expected)
        {
            int actual = Tasks.Arrays.findMaxElem(A);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { -3, 3, 1, 9, 6 }, 0)]
        [TestCase(new int[] { -3, -323, -1, 0, 6 }, 1)]
        [TestCase(new int[] { 0, 377, 1, 0, 6 }, 0)]
        static public void findMinElemIndex(int[] A, int expected)
        {
            int actual = Tasks.Arrays.findMinElemIndex(A);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { -3, 3, 1, 9, 6 }, 3)]
        [TestCase(new int[] { -3, -323, -1, 0, 6 }, 4)]
        [TestCase(new int[] { 0, 377, 1, 0, 6 }, 1)]
        static public void findMaxElemIndex(int[] A, int expected)
        {
            int actual = Tasks.Arrays.findMaxElemIndex(A);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { -3, 3, 1, 9, 6 }, 12)]
        [TestCase(new int[] { -3, -323, -1, 0, 6 }, -323)]
        [TestCase(new int[] { 0, 377, 1, 0, 6 }, 377)]
        static public void findSumOfOddIndexElems(int[] A, int expected)
        {
            int actual = Tasks.Arrays.findSumOfOddIndexElems(A);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {-3, 3, 1, 9, 6}, new int[] {6, 9, 1, 3, -3})]
        [TestCase(new int[] { -3, -323, -1, 0, 6 }, new int[] { 6, 0, -1, -323, -3 })]
        [TestCase(new int[] { 0, 377,2, 1, 0, 6 }, new int[] {6, 0, 1, 2, 377, 0})]

        static public void reverseArray(int[] A, int[] expected)
        {
            int[] actual = Tasks.Arrays.reverseArray(A);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {-3, 3, 1, 9, 6}, 10)]
        [TestCase(new int[] { -3, -323, -1, 0, 6 }, -327)]
        [TestCase(new int[] { 0, 377, 1, 0, 6 }, 378)]
        static public void findSumOfOdd(int[] A, int expected)
        {
            int actual = Tasks.Arrays.findSumOfOdd(A);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { -3, 3, 1, 0, 6 }, new int[] {0, 6, 1, -3, 3 })]
        [TestCase(new int[] { -3, -323, -1, 0, 6 }, new int[] { 0, 6, -1, -3, -323 })]
        [TestCase(new int[] { 0, 377, 2, 1, 0, 6 }, new int[] { 1, 0, 6, 0, 377, 2})]
        static public void swapHalfsOfArrays(int[] A, int[] expected)
        {
            int[] actual = Tasks.Arrays.swapHalfsOfArrays(A);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { -3, 3, 1, 0, 6 }, new int[] {-3, 0, 1, 3, 6})]
        [TestCase(new int[] { -3, -323, -1, 0, 6 }, new int[] { -323, -3, -1, 0, 6 })]
        [TestCase(new int[] { 0, 377, 2, 1, 0, 6 }, new int[] { 0, 0, 1, 2, 6, 377 })]
        static public void selectSort(int[] A, int[] expected)
        {
            int[] actual = Tasks.Arrays.selectSort(A);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { -3, 3, 1, 0, 6 }, new int[] {-3, 0, 1, 3, 6})]
        [TestCase(new int[] { -3, -323, -1, 0, 6 }, new int[] { -323, -3, -1, 0, 6 })]
        [TestCase(new int[] { 0, 377, 2, 1, 0, 6 }, new int[] { 0, 0, 1, 2, 6, 377 })]
        static public void insertSort(int[] A, int[] expected)
        {
            int[] actual = Tasks.Arrays.insertSort(A);
            Assert.AreEqual(expected, actual);
        }
    }
}