using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    static public class Branching
    {
        static public int calculateNums(int A, int B)
        {
            int ans;

            if (A > B)
            {
                ans = A + B;
            }
            else if (A == B)
            {
                ans = A * B;
            }
            else
            {
                ans = A - B;
            }

            return ans;
        }
        static public int findQuarter(int X, int Y)
        {

            if (X >= 0 && Y >= 0)
            {
                return 1;
            }

            else if (X < 0 && Y >= 0)
            {
                return 2;
            }

            else if (X < 0 && Y < 0)
            {
                return 3;
            }

            else
            {
                return 4;
            }
        }
        static public string sortingNums(int A, int B, int C)
        {
            if (A >= B)
            {
                if (C >= A)
                {
                    return $"{B} {A} {C}";
                }
                else
                {
                    return $"{B} {C} {A}";
                }
            }
            else
            {
                if (C >= B)
                {
                    return  $"{A} {B} {C}";
                }
                else
                {
                    return  $"{A} {C} {B}";
                }
            }
        }
        static public string calculateQuadraticEquation(int A, int B, int C)
        {
            float D = B * B - 4 * A * C;

            if (D > 0)
            {
                return $"{ (-B + Math.Round(Math.Sqrt(D), 3)) / (2 * A) }; { (-B - Math.Round(Math.Sqrt(D), 3)) / (2 * A) }";
            }
            else if (D == 0)
            {
                return $"{ -B / (2 * A) }";
            }
            else
            {
                return $"{-B} + {Math.Round(Math.Sqrt(-D), 3)}i / (2 * {A}); {-B} - {Math.Round(Math.Sqrt(-D), 3)}i / (2 * {A})";
            }
        }
        static public string printNumInChars(int A)
        {
            string input = $"{A}";
            string ans = "";
            if (input[0] == '1')
            {
                switch (input[1])
                {
                    case '0':
                       ans += "ten";
                        break;
                    case '1':
                       ans += "eleven";
                        break;
                    case '2':
                       ans += "twelve";
                        break;
                    case '3':
                       ans += "thirteen";
                        break;
                    case '4':
                       ans += "fourteen";
                        break;
                    case '5':
                       ans += "fifteen";
                        break;
                    case '6':
                       ans += "sixteen";
                        break;
                    case '7':
                       ans += "seventeen";
                        break;
                    case '8':
                       ans += "eighteen";
                        break;
                    case '9':
                       ans += "nineteen";
                        break;
                }
            }
            else
            {
                switch (input[0])
                {
                    case '2':
                       ans += "twenty ";
                        break;
                    case '3':
                       ans += "thirty ";
                        break;
                    case '4':
                       ans += "forty ";
                        break;
                    case '5':
                       ans += "fifty ";
                        break;
                    case '6':
                       ans += "sixty ";
                        break;
                    case '7':
                       ans += "seventy ";
                        break;
                    case '8':
                       ans += "eighty ";
                        break;
                    case '9':
                       ans += "ninety ";
                        break;
                }
                switch (input[1])
                {
                    case '1':
                       ans += "one";
                        break;
                    case '2':
                       ans += "two";
                        break;
                    case '3':
                       ans += "three";
                        break;
                    case '4':
                       ans += "four";
                        break;
                    case '5':
                       ans += "five";
                        break;
                    case '6':
                       ans += "six";
                        break;
                    case '7':
                       ans += "seven";
                        break;
                    case '8':
                       ans += "eight";
                        break;
                    case '9':
                       ans += "nine";
                        break;
                }
            }
            return ans;
        }

    }

}
