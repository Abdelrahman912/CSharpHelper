using System;

namespace CSharpHelper.Extensions
{
    public static class DoubleExtension
    {
        public static int GetIntHash(this double num) =>
            ((int)num).GetHashCode();

        public static double IfNegativeReturnOne(this double num) =>
            num < 0 ? 1 : num;

        public static double IfNegativeReturn(this double num, double value) =>
            num < 0 ? value : num;

        public static double TakeMin(this double num, double compareValue) =>
            Math.Min(num, compareValue);

        public static double TakeMinWithOne(this double num) =>
            Math.Min(num, 1);

        public static double Power(this double num, double power) =>
            Math.Pow(num, power);

        public static double Round(this double num, int digits) =>
            Math.Round(num, digits);

        public static bool IsEqual(this double num1 , double num2,double tol = 0.0002)=>
            Math.Abs(num1 - num2) < tol;
    }
}
