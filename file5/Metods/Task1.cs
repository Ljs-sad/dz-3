using System;
using System.Collections.Generic;
using System.Text;

namespace file5.Metods
{
    public class Task1
    {
        public static void RandomArray(int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 100);
            }
        }

        public static bool Reverse(int[] arr, int num1, int num2)
        {
            int ind1 = Array.IndexOf(arr, num1);
            int ind2 = Array.IndexOf(arr, num2);

            if (ind1 == -1 || ind2 == -1)
            {
                return false;
            }
            int x = arr[ind1];
            arr[ind1] = arr[ind2];
            arr[ind2] = x;

            return true;
        }
    }
}