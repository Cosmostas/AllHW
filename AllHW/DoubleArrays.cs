using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    static public class DoubleArrays
    {
        static public int findMinElem(int [,] arr)
        {
            int min = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
            }
            return min;
        }
        static public int findMaxElem(int [,] arr)
        {
            int max = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }

            return max;
        }
        static public int[] findMinElemIndex(int [,] arr)
        {
            int minFirstIndex = 0;
            int minLastIndex = 0;

            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    if (arr[i, j] < arr[minFirstIndex, minLastIndex])
                    {
                        minFirstIndex = i;
                        minLastIndex = j;
                    }
                }
            }

            return new int[] { minFirstIndex, minLastIndex };
        }
        static public int[] findMaxElemIndex(int [,] arr)
        {
            int maxFirstIndex = 0;
            int maxLastIndex = 0;

            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    if (arr[i, j] > arr[maxFirstIndex, maxLastIndex])
                    {
                        maxFirstIndex = i;
                        maxLastIndex = j;
                    }
                }
            }
            return new int[] { maxFirstIndex, maxLastIndex};
        }
        static public int findAmountBigerElem(int [,] arr)
        {
            int amount = 0;

            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            if (arr[i, j] > arr[i + 1, j] && arr[i, j] > arr[i, j + 1])
                            {
                                ++amount;
                            }
                        }
                        else if (j == arr.GetLength(1) - 1)
                        {
                            if (arr[i, j] > arr[i + 1, j] && arr[i, j] > arr[i, j - 1])
                            {
                                ++amount;
                            }
                        }
                        else
                        {
                            if (arr[i, j] > arr[i + 1, j] && arr[i, j] > arr[i, j - 1] && arr[i, j] > arr[i, j + 1])
                            {
                                ++amount;
                            }
                        }
                    }
                    else if (i == arr.GetLength(0) - 1)
                    {
                        if (j == 0)
                        {
                            if (arr[i, j] > arr[i - 1, j] && arr[i, j] > arr[i, j + 1])
                            {
                                ++amount;
                            }
                        }
                        else if (j == arr.GetLength(1) - 1)
                        {
                            if (arr[i, j] > arr[i - 1, j] && arr[i, j] > arr[i, j - 1])
                            {
                                ++amount;
                            }
                        }
                        else
                        {
                            if (arr[i, j] > arr[i - 1, j] && arr[i, j] > arr[i, j - 1] && arr[i, j] > arr[i, j + 1])
                            {
                                ++amount;
                            }
                        }
                    }
                    else
                    {
                        if (j == 0)
                        {
                            if (arr[i, j] > arr[i - 1, j] && arr[i, j] > arr[i + 1, j] && arr[i, j] > arr[i, j + 1])
                            {
                                ++amount;
                            }
                        }
                        else if (j == arr.GetLength(1) - 1)
                        {
                            if (arr[i, j] > arr[i - 1, j] && arr[i, j] > arr[i + 1, j] && arr[i, j] > arr[i, j - 1])
                            {
                                ++amount;
                            }
                        }
                        else
                        {
                            if (arr[i, j] > arr[i - 1, j] && arr[i, j] > arr[i + 1, j] && arr[i, j] > arr[i, j - 1] && arr[i, j] > arr[i, j + 1])
                            {
                                ++amount;
                            }
                        }
                    }
                }
            }
            return amount;
        }

        public static int[,] Transponse(int [,] arr) 
        {

            int[,] arrT = new int[arr.GetLength(1), arr.GetLength(0)];

            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    arrT[j, i] = arr[i, j];
                }
            }

            return arrT;
        }


    }
}
