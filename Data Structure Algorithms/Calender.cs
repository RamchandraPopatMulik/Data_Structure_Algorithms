using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Algorithms
{
    public class calender
    {
        private int[,] calendar = new int[6, 7];

        public void Getcalendar(int year, int month)
        {
            DateTime dateTime = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int currentDay = 1;
            var dayOfWeek = (int)dateTime.DayOfWeek;
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1) && currentDay - dayOfWeek + 1 <= days; j++)
                {
                    if (i == 0 && month > j)
                    {
                        calendar[i, j] = 0;
                    }
                    else
                    {
                        calendar[i, j] = currentDay - dayOfWeek + 1;
                        currentDay++;
                    }
                }
            }
        }
        public void PrintCalendar(int year,int month)
        {
            Console.WriteLine($"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month)} {year}");
            Console.WriteLine("Mon Tue Wed Thu Fri Sat Sun");
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1); j++)
                {
                    if (calendar[i, j] > 0)
                    {

                        if (calendar[i, j] < 10)
                        {
                            Console.Write($" {calendar[i, j]}  ");
                        }
                        else
                        {
                            Console.Write($"{calendar[i, j]}  ");
                        }
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine("");
            }

        }
    }
}
    

