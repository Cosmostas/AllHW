using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    public static class Arrays
    {
        public static int findMinElem(int[] arr)
        {
            int min = arr[0];

            for (int i = 1; i < arr.Length; ++i)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }

        public static int findMaxElem(int[] arr)
        {
            int max = arr[0];

            for (int i = 1; i < arr.Length; ++i)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        public static int findMinElemIndex(int[] arr)
        {
            int minElemIndex = 0;

            for (int i = 1; i < arr.Length; ++i)
            {
                if (arr[i] < arr[minElemIndex])
                {
                    minElemIndex = i;
                }
            }
            return minElemIndex;
        }
        public static int findMaxElemIndex(int[] arr)
        {
            int maxElemIndex = 0;

            for (int i = 1; i < arr.Length; ++i)
            {
                if (arr[i] > arr[maxElemIndex])
                {
                    maxElemIndex = i;
                }
            }
            return maxElemIndex;
        }
        public static int findSumOfOddIndexElems(int[] arr)
        {
            int sum = 0;

            for (int i = 1; i < arr.Length; i = i + 2)
            {
                sum += arr[i];
            }

            return sum;
        }
        public static int[] reverseArray(int[] arr)
        {
            int temp;

            for (int i = 0; i < arr.Length / 2; ++i)
            {
                temp = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = arr[i];
                arr[i] = temp;
            }

            return arr;
        }

        public static int findSumOfOdd(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] % 2 == 1 || arr[i] % 2 == -1)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }
        public static int[] swapHalfsOfArrays(int[] arr)
        {
            int temp;

            for (int i = 0; i < arr.Length / 2; ++i)
            {
                temp = arr[arr.Length / 2 + 1 + i];
                arr[arr.Length / 2 + 1 + i] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }

        public static int[] selectSort(int[] arr)
        {
            int temp;

            for (int i = 0; i < arr.Length; ++i)
            {
                temp = arr[i];

                int j;
                for (j = i; j > 0; --j)
                {
                    if (arr[j - 1] < temp)
                    {
                        break;
                    }
                    arr[j] = arr[j - 1];
                }
                arr[j] = temp;
            }
            return arr;
        } 

        public static int[] insertSort(int[] arr)
        {
            int temp;

            for (int i = 0; i < arr.Length; ++i)
            {
                temp = arr[i];

                int j;
                for (j = i; j > 0; --j)
                {
                    if (arr[j - 1] < temp)
                    {
                        break;
                    }
                    arr[j] = arr[j - 1];
                }
                arr[j] = temp;
            }
            return arr;
        }



    }
}
