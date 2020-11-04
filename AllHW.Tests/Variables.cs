using NUnit.Framework;
using Tasks;

namespace Tasks.Tests
{
    public class Variables
    {
        [TestCase(1, 2, 9)]
        [TestCase(5, -1, -4)]
        [TestCase(1, 3, 7)]
        [TestCase(6, 2, -8)]
        [TestCase(5, 2, -9)]
        static public void calculateExpression(int A, int B, int expected)
        {
            int actual = Tasks.Variables.calculateExpression(A, B);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(7, 7)]
        static public void negativeCalculateExpression(int A, int B)
        {

            try
            {
                Tasks.Variables.calculateExpression(A, B);
            }
            catch
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(2, 5, "5 2")]
        [TestCase(1, 2, "2 1")]
        [TestCase(6, 1, "1 6")]
        [TestCase(1, 0, "0 1")]
        [TestCase(6, -1, "-1 6")]

        static public void swapValue(int A, int B, string expected)
        {
            string actual = Tasks.Variables.swapValue(A, B);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 5, "0 2")]
        [TestCase(1, 2, "0 1")]
        [TestCase(6, 1, "6 0")]
        [TestCase(10, 5, "2 0")]
        [TestCase(6, -1, "-6 0")]
        static public void calculateDivisionAndMod(int A, int B, string expected)
        {
            string actual = Tasks.Variables.calculateDivisionAndMod(A, B);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(2, 0)]
        [TestCase(3, 0)]
        [TestCase(7, 0)]
        static public void negativeCalculateDivisionAndMod(int A, int B)
        {

            try
            {
                Tasks.Variables.calculateDivisionAndMod(A, B);
            }
            catch
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(1, 2, 3, 1)]
        [TestCase(4, 2, 3, 0.25)]
        [TestCase(6, 1, 8, 1.167)]
        [TestCase(-3, 1, 16, -5)]
        [TestCase(234, 1, 5, 0.017)]

        static public void calculateDividingTheDifference(int A, int B, int C, double expected)
        {
            double actual = Tasks.Variables.calculateDividingTheDifference(A, B, C);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 2, 5)]
        [TestCase(0, 4, 8)]
        [TestCase(0, 1, 1)]
        static public void negativeCalculateDividingTheDifference(int A, int B, int C)
        {

            try
            {
                Tasks.Variables.calculateDividingTheDifference(A, B, C);
            }
            catch
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(1, 1, 2, 2, "1 0")]
        [TestCase(1, 6, 5, 3, "0 3")]
        [TestCase(1, -1, 2, -2, "-1 0")]
        [TestCase(1, 1, 2, 4, "3 -2")]
        [TestCase(1, 0, 0, 2, "-2 2")]
        static public void calculateCoefficients(int X1, int Y1, int X2, int Y2, string expected)
        {
            string actual = Tasks.Variables.calculateCoefficients(X1, Y1, X2, Y2);
            Assert.AreEqual(expected, actual);
        }

    }
}