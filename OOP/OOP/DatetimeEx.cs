using System;

namespace OOP
{
    internal class DatetimeEx
    {
        public static void DatetimeExample()
        {
            var date = new DateTime(2001, 1, 12);
            Console.WriteLine("\n" + date);

            var formatedDate = date.ToString("yyyy, MMMM dd");
            Console.WriteLine("\n" + formatedDate);

            var forward = date.AddYears(10);
            Console.WriteLine("\n" + forward);

            var passed = TimeSpan.FromDays(10);
            Console.WriteLine("\n" + passed);
            Console.WriteLine(DateTime.Today);
        }
    }
}
