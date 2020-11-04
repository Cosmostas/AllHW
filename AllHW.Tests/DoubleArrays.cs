using NUnit.Framework;
using Tasks;

namespace Tasks.Tests
{
    public static class DoubleArrays
    {
        [TestCase(1, -4)]
        [TestCase(2, -23)]
        [TestCase(3, -4)]
        public static void findMinElem(int numMock, int expected)
        {
            int[,] arr = Mocks.getArrayMock(numMock);
            int actual = Tasks.DoubleArrays.findMinElem(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 55)]
        [TestCase(2, 12)]
        [TestCase(3, 8)]
        public static void findMaxElem(int numMock, int expected)
        {
            int[,] arr = Mocks.getArrayMock(numMock);
            int actual = Tasks.DoubleArrays.findMaxElem(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] {1,0})]
        [TestCase(2, new int[] {2,1})]
        [TestCase(3, new int[] {1,1})]

        public static void findMinElemIndex(int numMock, int[] expected)
        {
            int[,] arr = Mocks.getArrayMock(numMock);
            int[] actual = Tasks.DoubleArrays.findMinElemIndex(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] {2, 0})]
        [TestCase(2, new int[] {2, 0})]
        [TestCase(3, new int[] {0, 0})]
        public static void findMaxElemIndex(int numMock, int[] expected)
        {
            int[,] arr = Mocks.getArrayMock(numMock);
            int[] actual = Tasks.DoubleArrays.findMaxElemIndex(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 2)]
        public static void findAmountBigerElem(int numMock, int expected)
        {
            int[,] arr = Mocks.getArrayMock(numMock);
            int actual = Tasks.DoubleArrays.findAmountBigerElem(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        public static void Transponse(int numMock, int numExpectedMock)
        {
            int[,] expected = Mocks.getExpectedArrayMock(numExpectedMock);
            int[,] arr = Mocks.getArrayMock(numMock);
            int[,] actual = Tasks.DoubleArrays.Transponse(arr);
            Assert.AreEqual(expected, actual);
        }
        

        
    }
}