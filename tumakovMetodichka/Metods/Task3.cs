using System;

namespace tumakovMetodichka.Metods
{
    public class Task3
    {
        public static bool Factorial(ref ulong arg, out ulong res)
        {
            res = 1;
            try
            {
                checked
                {
                    for (ulong i = 1; i <= arg; i++)
                    {
                        res *= i;
                    }
                }
                return true;
            }
            catch (OverflowException)
            {
                res = 0;
                return false;
            }
        }
    }
}
