﻿using System;

namespace Tasks
{
    static public class Variables
    {
        static public int calculateExpression(int A, int B)
        {
            if(B - A == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return (5 * A + B * B) / (B - A);
            }
        }
        static public string swapValue(int A, int B)
        {
            int temp;
            temp = A;
            A = B;
            B = temp;
            return $"{A} {B}";
        }
        static public string calculateDivisionAndMod(int A, int B)
        {
            // Need to add exception ZeroDevizion
            return $"{A / B} {A % B}";
        }
        static public double calculateDividingTheDifference(int A, int B, int C)
        {
            // Need to add exception ZeroDevizion
            return Math.Round((float)(C - B) / (float)A, 3);
        }
        static public string calculateCoefficients(int X1, int Y1, int X2, int Y2)
        {
            float A = (Y2 - Y1) / (X2 - X1);
            float B = Y2 - X2 * A;
            return $"{A} {B}";
     
        }
    }
}
