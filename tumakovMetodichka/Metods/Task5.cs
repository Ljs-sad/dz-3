namespace tumakovMetodichka.Metods
{
    public class Task5
    {
        public static int NOD(int num1, int num2)
        {
            while (num2 != 0)
            {
                int x = num2;
                num2 = num1 % num2;
                num1 = x;
            }
            return num1;
        }

        public static int NOD(int num1, int num2, int num3)
        {
            return NOD(NOD(num1, num2), num3);
        }
    }
}
