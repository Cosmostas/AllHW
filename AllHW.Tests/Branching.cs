using NUnit.Framework;
using Tasks;

namespace Tasks.Tests
{
    public class Branching
    {
        [TestCase(3, 3, 9)]
        static public void calculateNums(int A, int B, int expected)
        {
            int actual = Tasks.Branching.calculateNums(A, B);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, -2, 4)]
        static public void findQuarter(int X, int Y, int expected)
        {
            int actual = Tasks.Branching.findQuarter(X, Y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, -2, 4, "-2 3 4")]
        static public void sortingNums(int A, int B, int C, string expected)
        {
            string actual = Tasks.Branching.sortingNums(A, B, C);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, -2, 4, "2 + 6,633i / (2 * 3); 2 - 6,633i / (2 * 3)")]
        static public void calculateQuadraticEquation(int A, int B, int C, string expected)
        {
            string actual = Tasks.Branching.calculateQuadraticEquation(A, B, C);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(33, "thirty three")]
        static public void printNumInChars(int A, string expected)
        {
            string actual = Tasks.Branching.printNumInChars(A);
            Assert.AreEqual(expected, actual);
        }

    }
}