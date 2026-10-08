namespace tumakovMetodichka.Metods
{
    public class Task4
    {
        public static ulong FactorialRecurs(ulong arg)
        {
            if (arg <= 1)
            {
                return 1;
            }
            return arg * FactorialRecurs(arg - 1);
        }
    }
}
