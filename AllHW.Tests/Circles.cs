using NUnit.Framework;
using Tasks;

namespace Tasks.Tests
{
    public class Circles
    {
        [TestCase(3, 3, 27)]
        [TestCase(2, 8, 256)]
        [TestCase(6, 3, 216)]
        [TestCase(5, 2, 25)]
        [TestCase(8, 0, 1)]
        static public void calculateDegree(int A, int B, int expected)
        {
            int actual = Tasks.Circles.calculateDegree(A, B);
            Assert.AreEqual(expected, actual);
        } 

        [TestCase(59, "59 118 177 236 295 354 413 472 531 590 649 708 767 826 885 944 ")]
        [TestCase(187, "187 374 561 748 935 ")]
        [TestCase(387, "387 774 ")]
        [TestCase(999, "999 ")]
        [TestCase(800, "800 ")]
        static public void findNumInInterval(int A, string expected)
        {
            string actual = Tasks.Circles.findNumInInterval(A);
            Assert.AreEqual(expected, actual);
        } 
        

        [TestCase(9, 2)]
        [TestCase(37, 6)]
        [TestCase(53, 7)]
        [TestCase(2, 1)]
        [TestCase(28, 5)]
        static public void findAmountSmallerSquares(int A, int expected)
        {
            int actual = Tasks.Circles.findAmountSmallerSquares(A);
            Assert.AreEqual(expected, actual);
        } 

        [TestCase(9, 3)]
        [TestCase(456, 228)]
        [TestCase(13, 1)]
        [TestCase(25, 5)]
        [TestCase(4, 2)]
        static public void findLargestDivisor(int A, int expected)
        {
            int actual = Tasks.Circles.findLargestDivisor(A);
            Assert.AreEqual(expected, actual);
        } 

        [TestCase(1, 9, 7)]
        [TestCase(1, 27, 42)]
        [TestCase(13, 6, 7)]
        [TestCase(2, 5, 0)]
        [TestCase(37, 9, 98)]
        static public void findSumDivisibleBySeven(int A, int B, int expected)
        {
            int actual = Tasks.Circles.findSumDivisibleBySeven(A, B);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 2)]
        [TestCase(5, 3)]
        [TestCase(1, 0)]
        [TestCase(2, 1)]
        [TestCase(10, 34)]
        static public void findFibinociNumber(int N, int expected)
        {
            int actual = Tasks.Circles.findFibinociNumber(N);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(27, 9, 9)]
        [TestCase(5, 27, 1)]
        [TestCase(3, 3, 3)]
        [TestCase(6, 9, 3)]
        [TestCase(76, 213, 1)]
        static public void findLeastCommonDivide(int A, int B, int expected)
        {
            int actual = Tasks.Circles.findLeastCommonDivide(A, B);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(27, 3)]
        [TestCase(64, 4)]
        [TestCase(-8, -2)]
        [TestCase(-1, -1)]
        [TestCase(125, 5)]
        static public void findCubicRoot(int N, int expected)
        {
            int actual = Tasks.Circles.findCubicRoot(N);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("123", 2)]
        [TestCase("1423", 2)]
        [TestCase("12123", 3)]
        [TestCase("1276", 2)]
        [TestCase("123567", 4)]
        static public void findAmountOdd(string A, int expected)
        {
            int actual = Tasks.Circles.findAmountOdd(A);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(123, 321)]
        [TestCase(15623, 32651)]
        [TestCase(3457, 7543)]
        [TestCase(9231, 1329)]
        [TestCase(5, 5)]
        static public void reverseNumber(int A, int expected)
        {
            int actual = Tasks.Circles.reverseNumber(A);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(13, 5)]
        [TestCase(123, 53)]
        [TestCase(3, 1)]
        [TestCase(63, 30)]
        [TestCase(1, 0)]
        static public void findAmountNumsWithBiggerEven(int N, int expected)
        {
            int actual = Tasks.Circles.findAmountNumsWithBiggerEven(N);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("123", "34534", "Yes")]
        [TestCase("1223", "", "No")]
        [TestCase("12", "6", "No")]
        [TestCase("10", "0", "Yes")]
        [TestCase("31", "1123", "Yes")]
        static public void findEquelNum(string A, string B, string expected)
        {
            string actual = Tasks.Circles.findEquelNum(A, B);
            Assert.AreEqual(expected, actual);
        }

    }
}