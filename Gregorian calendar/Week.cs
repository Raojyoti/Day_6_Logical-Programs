﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Gregorian_calendar
{
    internal class Week
    {
        public static int day, month, year;
        public static void DayOfWeek()
        {
            if (month == 1)
            {
                month = 13;
                year--;
            }
            if (month == 2)
            {
                month = 14;
                year--;
            }
            int m = month;
            int d = day;
            int y = year;
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;

            d0 = d0 % 7;
            switch (d0)
            {
                case 0:
                    Console.WriteLine("Saturday");
                    break;

                case 1:
                    Console.WriteLine("Sunday");
                    break;

                case 2:
                    Console.WriteLine("Monday");
                    break;

                case 3:
                    Console.WriteLine("Tuesday");
                    break;

                case 4:
                    Console.WriteLine("Wednesday");
                    break;

                case 5:
                    Console.WriteLine("Thursday");
                    break;

                case 6:
                    Console.WriteLine("Friday");
                    break;
            }

        }
    }
}
