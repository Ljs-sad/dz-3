namespace file5.Metods
{
    internal class Task3
    {
        public static void PrintDigit(ref int digit)
        {
            Console.WriteLine($"\nРисуем цифру {digit}:");
            switch (digit)
            {
                case 0:
                    Console.WriteLine(" ### \n#   #\n#   #\n#   #\n ### ");
                    break;
                case 1:
                    Console.WriteLine("  #  \n ##  \n  #  \n  #  \n ### ");
                    break;
                case 2:
                    Console.WriteLine(" ### \n#   #\n  ## \n #   \n#####");
                    break;
                case 3:
                    Console.WriteLine("#### \n    #\n ### \n    #\n#### ");
                    break;
                case 4:
                    Console.WriteLine("#   #\n#   #\n#####\n    #\n    #");
                    break;
                case 5:
                    Console.WriteLine("#####\n#    \n#### \n    #\n#### ");
                    break;
                case 6:
                    Console.WriteLine(" ### \n#    \n#### \n#   #\n ### ");
                    break;
                case 7:
                    Console.WriteLine("#####\n    #\n   # \n  #  \n #   ");
                    break;
                case 8:
                    Console.WriteLine(" ### \n#   #\n ### \n#   #\n ### ");
                    break;
                case 9:
                    Console.WriteLine(" ### \n#   #\n ####\n    #\n ### ");
                    break;
            }
            Console.WriteLine();
        }
    }
}

