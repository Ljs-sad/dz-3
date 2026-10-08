namespace tumakovMetodichka.Metods
{
    public class Task2
    {
        public static void Reverse(ref int x, ref int y)
        {
            var z = x;
            x = y;
            y = z;
        }
    }
}
