using System;
using tumakovMetodichka.Metods;

namespace tumakovMetodichka
{
    internal class Program
    {
            static void Main(string[] args)
        {
            //упражнение 5.1 - метод на нахождение максимального числа
            Console.WriteLine("- Упражнение 5.1 - \n(Найти максимум из двух чисел)");
            Console.WriteLine("Введите два целых числа (каждое с новой строки): ");

            if (int.TryParse(Console.ReadLine(), out int a) && int.TryParse(Console.ReadLine(), out int b))
            {
                int result = Task1.Maxi(a, b);
                Console.WriteLine($"Наибольшее число: {result}");
            }
            else
            {
                Console.WriteLine("Ошибка. Введите корректные значения!");
            }
            Console.ReadKey();


            //упражнение 5.2 - метод на перестановку аргументов
            Console.WriteLine("- Упражнение 5.2 - \n(Поменять два аргумента местами)");
            Console.WriteLine("Введите два целых числа (каждое с новой строки): ");

            if (int.TryParse(Console.ReadLine(), out int x) && int.TryParse(Console.ReadLine(), out int y))
            {
                Console.WriteLine($"До обмена: arg1 = {x}, arg2 = {y}");
                Task2.Reverse(ref x, ref y);
                Console.WriteLine($"После обмена: arg1 = {x}, arg2 = {y}");
            }
            else
            {
                Console.WriteLine("Ошибка. Введите корректные значения!");
            }
            Console.ReadKey();

            

            //упражнение 5.3 - метод факториала числа (с проверкой переполнения)
            Console.WriteLine("- Упражнение 5.3 - \n(Посчитать факториал числа)");
            Console.Write("Введите целое неотрицательное число: ");

            if (ulong.TryParse(Console.ReadLine(), out ulong arg))
            {
                if (Task3.Factorial(ref arg, out ulong factorial))
                {
                    Console.WriteLine($"Факториал {arg} равен {factorial}");
                }
                else
                {
                    Console.WriteLine("Ошибка. Привычислении произошло переполнение!");
                }
            }
            else
            {
                Console.WriteLine("Ошибка. Введите корректное значение!");
            }
            Console.ReadKey();


            //упражнение 5.4 - метод рекурсивноего факториала числа (с проверкой переполнения)
            Console.WriteLine("- Упражнение 5.4 - \n(Посчитать факториал числа)");
            Console.Write("Введите целое неотрицательное число: ");
            if (ulong.TryParse(Console.ReadLine(), out ulong arg1))
            {
                ulong result = Task4.FactorialRecurs(arg1);
                Console.WriteLine($"Факториал {arg1} равен {result}");
            }
            else
            {
                Console.WriteLine("Ошибка. Введите корректное значение!");
            }
            Console.ReadKey();


            //Домашнее задание 5.1 - метод вычисляет НОД двух натуральных чисел (алгоритм Евклида)
            Console.WriteLine("- Упражнение 5.1 (1) - \n(вычислить НОД двух натуральных чисел)");
            Console.WriteLine("Введите два целых неотрицательных числа (каждое с новой строки): ");

            if (!int.TryParse(Console.ReadLine(), out int num1) || !int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Ошибка. Введите корректные данные!");
            }
            else if (num1 <= 0 || num2 <= 0)
            {
                Console.WriteLine("Ошибка. Числа должны быть натуральными(больше 0)!");
            }
            else
            {
                Console.WriteLine($"НОД({num1}, {num2}) = {Task5.NOD(num1, num2)}");
            }
            Console.ReadKey();

            //метод вычисляет НОД трёх натуральных чисел
            Console.WriteLine("- Домашнее задание 5.1 (2) - \n(вычислить НОД трёх натуральных чисел)");
            Console.WriteLine("Введите три целых неотрицательных числа (каждое с новой строки): ");
            if (!int.TryParse(Console.ReadLine(), out int numm1)
                || !int.TryParse(Console.ReadLine(), out int numm2)
                || !int.TryParse(Console.ReadLine(), out int numm3))
            {
                Console.WriteLine("Ошибка. Введите корректные данные!");
            }
            else if (numm1 <= 0 || numm2 <= 0 || numm3 <= 0)
            {
                Console.WriteLine("Ошибка. Числа должны быть натуральными(больше 0)!");
            }
            else
            {
                Console.WriteLine($"НОД({numm1}, {numm2}, {numm3}) = { Task5.NOD(numm1, numm2, numm3)}");
            }
            Console.ReadKey();


            //Домашнее задание 5.2 - рекурсивный метод, вычисляющий значение n-го числа ряда Фибоначчи.
            Console.WriteLine("- Домашнее задание 5.2 - \n(вычислить значение n-го числа ряда Фибоначчи.)");
            Console.WriteLine("Введите номер числа Фибоначчи (n > 0): ");
            if (int.TryParse(Console.ReadLine(), out int fibNum) && fibNum >= 0)
            {
                Console.WriteLine($"{fibNum}-е число Фибоначчи = {Task6.Fibonachi(fibNum)}");
            }
            else
            {
                Console.WriteLine("Ошибка. Введите корректные данные!");
            }
            Console.ReadKey();
        }
    }
}
