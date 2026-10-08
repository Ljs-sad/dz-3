namespace tumakovMetodichka.Metods
{
    public class Task6
    {
        public static int Fibonachi(int fibNum)
        {
            if (fibNum <= 2)
            {
                return 1;
            }
            return Fibonachi(fibNum - 1) + Fibonachi(fibNum - 2);
        }
    }
}
