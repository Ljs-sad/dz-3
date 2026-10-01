using file.DopClass;
using file.Enums;
using System;

namespace file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            Console.WriteLine("- Задача 1. -\n- проверка упорядоченности последовательности из 10 чисел -");
            Console.WriteLine("введите 10 целых чисел (каждое с новой строки): ");
            int[] numbers = new int[10];
            bool flag = true;
            int indexer = -1;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Число {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Ошибка, введите целое число: ");
                }
            }

            for (int i = 0;i < numbers.Length - 1; i++)
            {
                if (numbers[i] >  numbers[i + 1])
                {
                    flag = false;
                    indexer += 1;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Последовательность упорядочена по возрастанию.");
            }
            else
            {
                Console.WriteLine($"Последовательность нарушена: число {numbers[indexer]} (порядковый номер: {indexer + 1}) меньше предыдущего.");
            }
            Console.ReadKey();

            //задание 2
            Console.WriteLine("- Задача 2. -\n- по номеру карты k(6 <= k <= 14) определить её достоинство -");
            Console.WriteLine("Введите номер карты (6-14): ");
            string card = Console.ReadLine();
            int k;

            try
            {
                string[] cards = new string[15];
                cards[6] = "шестёрка";
                cards[7] = "семёрка";
                cards[8] = "восьмёрка";
                cards[9] = "девятка";
                cards[10] = "десятка";
                cards[11] = "валет";
                cards[12] = "дама";
                cards[13] = "король";
                cards[14] = "туз";

                if (int.TryParse(card, out k))
                {
                    if (k < 6 || k > 14)
                    {
                        throw new ArgumentOutOfRangeException("Номер карты должен быть в диапозоне от 6 до 14.");
                    }
                    if (k >= 6 && k <= 14)
                    {
                        Console.WriteLine($"Карта под номером {k} - {cards[k]}");
                    }
                }
                else
                {
                    throw new FormatException("Введите корректное число.");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message); 
            }
            finally
            {
                Console.WriteLine("Конец");
            }
            Console.ReadKey();

            //задание 3
            Console.WriteLine("- Задача 3. -\n- вывести по профессии напиток -");
            Console.WriteLine("Введите вашу профессию: ");
            string prof = Console.ReadLine();

            string drink = Drinks.DrinkProf(prof);
            Console.WriteLine($"Ваш напиток: {drink}");
            Console.ReadKey();

            //задание 4
            Console.WriteLine("- Задача 4. -\n- по порядковому номеру дня недели (1-7) вывести его название -");
            Console.WriteLine("Введите номер дня недели (1-7): ");

            if (int.TryParse(Console.ReadLine(), out int dayNum))
            {
                if (dayNum >=1 && dayNum <= 7)
                {
                    WeekDay day = (WeekDay)dayNum;
                    Console.WriteLine($"День недели: {WeekDays.Vivod(day)}");
                }
                else
                {
                    Console.WriteLine("Ошибка, число должно быть от 1 до 7");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не число.");
            }
            Console.ReadKey();

            //задание 5
            Console.WriteLine("- Задача 5. -\n- обойти массив строк через foreach и посчитать, сколько кукол -");
            string[] dools = { "Car", "Hello Kitty", "Lego", "Puzzle", "Barbie dool", "Hello Kitty", "Yo-yo", "Teddy bear", "Barbie dool"};
            int summDoll = 0;

            foreach (string i in dools)
            {
                if (i == "Hello Kitty" || i == "Barbie dool")
                {
                    summDoll++;
                }
            }
            Console.WriteLine($"Количество кукол в сумке: {summDoll}");
            Console.ReadKey();
        }   
    }
}
