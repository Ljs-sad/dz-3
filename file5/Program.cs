using System;
using file5.Metods;

namespace file5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 - Вывести на экран массив из 20 случайных чисел и поменять два числа, вводимых пользователем, местами
            Console.WriteLine("- Задание 1. - \n(Вывести на экран массив из 20 случайных чисел и поменять два числа, вводимых пользователем, местами)");
            int[] array = new int[20];
            Task1.RandomArray(array);

            Console.Write("Исходный массив : ");
            Console.Write(string.Join(", ", array));

            Console.WriteLine("Введите два целых числа для обмена (каждое с новой строки): ");
            if (int.TryParse(Console.ReadLine(), out int numb1) && int.TryParse(Console.ReadLine(), out int numb2))
            {
                if (Task1.Reverse(array, numb1, numb2))
                {
                    Console.WriteLine($"Массив после обмена: ");
                    Console.WriteLine(string.Join(", ", array));
                }
                else
                {
                    Console.WriteLine("Ошибка. Одно илт оба числа не найдены в массиве!");
                }
            }
            else
            {
                Console.WriteLine("Ошибка. Введите корректные значения!");
            }
            Console.ReadKey();


            //Задание 2 - Вывести сумму элементов массива (вернуть). Вывести произведение\nмассива. Вывести среднее арифметическое в массиве.
            Console.WriteLine("- Задание 2. - \n(Вывести сумму элементов массива (вернуть). Вывести произведение\nмассива. Вывести среднее арифметическое в массиве.)");
            Console.WriteLine("Введите 5 чисел (каждое с новой строки): ");
            int[] numbers = { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) };

            int product = 1;
            Task2.ProductOfNumbers(ref product, numbers);

            Task2.SrArif(out double srArif, numbers);

            Console.WriteLine($"Сумма элементов массива: {Task2.Sums(numbers)}\n" +
                $"Произведение элементов массива: {product}\n" +
                $"Среднее арифметическое: {srArif}");

            Console.ReadKey();


            //Задание 3 - обработать ввод числа и вывести в консоль представление заданной цифры(#)
            Console.WriteLine("- Задание 3. - \n(обработать ввод числа и вывести в консоль представление заданной цифры(#))");
            Console.WriteLine("Введите цифру 0-9, 'exit' или 'закрыть' для выхода.");

            while (true)
            {
                Console.Write("Ввод: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit" || input.ToLower() == "закрыть")
                {
                    Console.WriteLine("Завершение работы программы.");
                    break;
                }

                if (int.TryParse(input, out int digit))
                {
                    if (digit >= 0 && digit <= 9)
                    {
                        Task3.PrintDigit(ref digit);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка. Число выходит за пределы диапозона (0-9)!");
                        Thread.Sleep(3000);
                        Console.ResetColor();
                    }
                }
                else
                {
                    throw new Exception($"Введена некорректная строка: '{input}'.");
                }

            }

            Console.ReadKey();
        }
    }
             
}
