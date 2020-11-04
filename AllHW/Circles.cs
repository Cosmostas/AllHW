using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    static public class Circles
    {
        static public int calculateDegree(int A, int B)
        {
            int ans = 1;
            while (B != 0)
            {
                ans *= A;
                --B;
            }
            return ans; 
        }
        static public string findNumInInterval(int A)
        {
            string ans = "";
            for (int i = A; i <= 1000; ++i)
            {
                if (i % A == 0)
                {
                    ans += i + " ";
                }
            }
            return ans;
        }
        static public int findAmountSmallerSquares(int A)
        {
            int amount = 0;

            for (int i = 1; i < A; ++i)
            {
                if (i * i >= A)
                {
                    break;
                }
                else
                {
                    ++amount;
                }
            }

            return amount;
        }
        static public int findLargestDivisor(int A)
        {
            int ans = A - 1;
            while (A % ans != 0)
            {
                if (ans == 1)
                {
                    break;
                }
                --ans;
            }
            return ans;
        }
        static public int findSumDivisibleBySeven(int A, int B)
        {
            int step;

            if (A > B)
            {
                step = -1;
            }
            else
            {
                step = 1;
            }

            int ans = 0;
            for (int i = A; i != B; i += step)
            {
                if (i % 7 == 0)
                {
                    ans += i;
                }
            }

            return ans;
        }
        static public int findFibinociNumber(int N)
        {
            int firstNum = 0;
            int secondNum = 1;
            int temp;

            for (int i = 0; i < N - 1; ++i)
            {
                temp = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = temp;
            }

            return firstNum;
        }
        static public int findLeastCommonDivide(int A, int B)
        {
            while (A != B)
            {
                if (A > B)
                {
                    A -= B;
                }
                else
                {
                    B -= A;
                }
            }

            return A;
        } 
        static public int findCubicRoot(int N)
        {
            int goal;
            if (N > 0)
            {
                goal = N;
            }
            else
            {
                goal = -N;
            }

            int rightBorder = goal;
            int leftBorder = 1;

            int ans = (leftBorder + rightBorder) / 2;

            while (ans * ans * ans != goal)
            {
                if (ans * ans * ans > goal)
                {
                    rightBorder = ans;
                }
                else
                {
                    leftBorder = ans;
                }
                ans = (leftBorder + rightBorder) / 2;

            }
            if(N > 0)
            {
                return ans;
            }
            else
            {
                return -ans;
            }
        } 
        static public int findAmountOdd(string A)
        { 
            int ans = 0;
            for (int i = 0; i < A.Length; ++i)
            {
                if (Convert.ToInt32(A[i]) % 2 != 0)
                {
                    ++ans;
                }
            }

            return ans;
        }
        static public int reverseNumber(int A)
        {
            string str = $"{A}";
            string ans = "";
            for (int i = 0; i < str.Length; ++i)
            {
                ans += str[str.Length - i - 1];
            }

            return int.Parse(ans);
        }
        static public int findAmountNumsWithBiggerEven(int N)
        {
            int ans = 0;
            int amountOdd = 0;
            int amountEven = 0;
            int curentNum;
            for (int i = 1; i <= N; ++i)
            {
                curentNum = i;
                while (curentNum != 0)
                {
                    if (curentNum % 2 != 0)
                    {
                        amountOdd += curentNum % 10;
                    }
                    else
                    {
                        amountEven += curentNum % 10;
                    }
                    curentNum /= 10;
                }
                if (amountEven > amountOdd)
                {
                    ++ans;
                   
                }
                amountOdd = 0;
                amountEven = 0;
            }
            return ans;
        }
        static public string findEquelNum(string A, string B)
        {

            bool isThereEquel = false;
            for (int i = 0; i < A.Length; ++i)
            {
                if (isThereEquel)
                {
                    break;
                }

                for (int j = 0; j < B.Length; ++j)
                {
                    if (A[i] == B[j])
                    {
                        isThereEquel = true;
                        break;
                    }
                }
            }

            if (isThereEquel)
            {
               return "Yes";
            }
            else
            {
                return "No";
            }
        }

    }
}
