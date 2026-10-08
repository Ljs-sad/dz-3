using System;

namespace file5.Metods
{
    public class Task2
    {
        public static int Sums(params int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            return sum;
        }

        public static void ProductOfNumbers(ref int res, int[] array)
        {
            res = 1;
            foreach (int i in array)
            {
                res *= i;
            }
        }

        public static void SrArif(out double res, int[] array)
        {
            double sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            res = sum / array.Length;
        }
    }
}
