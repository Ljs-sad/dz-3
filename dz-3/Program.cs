using System;

namespace dz_3
{
    internal class Program
    {
        static string GetMonthName(int month)
        {
            string[] monthName =
            {
                "января", "февраля", "марта", "апреля",
                "мая", "июня", "июля", "августа",
                "сентября", "октября", "ноября", "декабря"
                };
            return monthName[month - 1];
        }
        static bool IsLeapYear(int year)
        {
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            return year % 4 == 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 4.1");
            Console.Write("Введите номер дня в году: ");
            int dayOfYear = int.Parse(Console.ReadLine());
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            if (dayOfYear < 1 || dayOfYear > 365) // для упражнения 4.2
            {
                Console.WriteLine("Ошибка: введите число от 1 до 365.");
                return;
            }

            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int month = 0;
            while (dayOfYear > daysInMonth[month])
            {
                dayOfYear -= daysInMonth[month];
                month++;
            }
            Console.WriteLine($"Результат: {dayOfYear} {GetMonthName(month + 1)} {year}");

            Console.ReadKey();

            Console.WriteLine("Домашнее задание 4.1");
            Console.Write("Введите номер дня в году: ");
            int dayOfYear2 = int.Parse(Console.ReadLine());
            Console.Write("Введите год: ");
            int year2 = int.Parse(Console.ReadLine());

            int maxDay = IsLeapYear(year2) ? 366 : 365;
            if (dayOfYear2 < 1 || dayOfYear2 > maxDay) 
            {
                Console.WriteLine($"Ошибка: введите число от 1 до {maxDay}.");
                return;
            }

            int[] daysInMonth2 = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (IsLeapYear(year2))
            {
                daysInMonth2[1] = 29;
            }
            int month2 = 0;
            while (dayOfYear2 > daysInMonth2[month2])
            {
                dayOfYear2 -= daysInMonth2[month2];
                month2++;
            }
            Console.WriteLine($"Результат: {dayOfYear2} {GetMonthName(month2 + 1)} {year2}");

            Console.ReadKey();      
        }

    }
}
