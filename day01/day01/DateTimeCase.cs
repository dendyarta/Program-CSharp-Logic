using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day01
{
    internal class DateTimeCase
    {
        public static void DateTimeCases()
        {
            DateTime now = DateTime.Now; 

            int day = now.Day;
            int month = now.Month;
            int year = now.Year;
            int hour = now.Hour;
            int minute = now.Minute;
            int second = now.Second;

            // only date
            DateTime onlyDate = now.Date;
            Console.WriteLine($"Only Date : {onlyDate}");

            // day of week
            DayOfWeek dayOfWeek = now.DayOfWeek;
            DayOfWeek Kamis = DayOfWeek.Thursday;

            // addDays
            DateTime tomorrow = now.AddDays(2);

            // Selisih Hari
            TimeSpan dateDifferemce = tomorrow - now;
            int dayRemaining = dateDifferemce.Days;
            Console.WriteLine($"{now} - {tomorrow}, selisih : {dayRemaining}");

            // Store Spesific date
            DateTime birthDay = new DateTime(1998, 12, 03);

        }
    }
}
