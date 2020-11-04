using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Tests
{
    public static class Mocks
    {
        public static int[,] getArrayMock(int numMock) 
        {
            switch (numMock)
            {
                case 1:
                    return new int[,] { { 1, 2, 3 }, { -4, 8, 13 }, { 55, 0, -3 } };
                case 2:
                    return new int[,] { { 8, 2 }, { -4, 8 }, { 12, -23 } };
                case 3:
                    return new int[,] { { 8, 2, 7 }, {3, -4, 8 }};
                default:
                    throw new Exception("No such option");
            }
        }
        public static int[,] getExpectedArrayMock(int numMock) 
        {
            switch (numMock)
            {
                case 1:
                    return new int[,] { { 1, -4, 55 }, { 2, 8, 0 }, { 3, 13, -3 } };
                case 2:
                    return new int[,] { { 8, -4, 12 }, { 2, 8, -23 } };
                case 3:
                    return new int[,] { { 8, 3 }, { 2, -4 }, { 7, 8 } };
                default:
                    throw new Exception("No such option");
            }
        }
    }
}
