using System;
using System.Text;
using file.Enums;

namespace file.DopClass
{
    public static  class WeekDays
    {
        public static string Vivod(WeekDay day)
        {
            switch (day)
            {
                case WeekDay.Monday:
                    return "Понедельник";
                case WeekDay.Tuesday:
                    return "Вторник";
                case WeekDay.Wednesday:
                    return "Среда";
                case WeekDay.Thursday:
                    return "Четверг";
                case WeekDay.Friday:
                    return "Пятница";
                case WeekDay.Saturday:
                    return "Суббота";
                case WeekDay.Sunday:
                    return "Воскресенье";
                default:
                    return "Неизвестный день";
            }
        }
    }
}
