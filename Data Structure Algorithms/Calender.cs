using Data_Structure_Algorithms;
using Microsoft.VisualStudio.OLE.Interop;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Algorithms
{
    public class CalendarWeek<T>
    {
        public CalendarWeek<T> next;
        public CalendarWeek<T> head;

        public int date;
        public CalendarWeek()
        {

        }
        public CalendarWeek(int date)
        {
            this.date = date;
            this.next = null;
        }

        public void InsertAtLast(CalendarWeek<T> temp)
        {
            if (head == null)
            {
                head = temp;
            }
            else
            {
                CalendarWeek<T> traverse = this.head;
                while (traverse.next != null)
                {
                    traverse = traverse.next;
                }
                traverse.next = temp;

            }
        }
        public void DisplayWeek()
        {
            CalendarWeek<T> temp = head;
            while (temp != null)
            {
                if (temp.date > 0)
                {
                    if (temp.date < 10)
                    {
                        Console.Write($"  {temp.date} ");
                    }
                    else
                    {
                        Console.Write($"{temp.date}  ");
                    }

                }
                else
                {
                    Console.Write("  ");

                }
                temp = temp.next;
            }
            Console.WriteLine("\n");
        }
    }
}
    public class calender
    {
    private int[,] calendar = new int[6, 7];
    private Queue<CalendarWeek<Calendar>> weekQueue = new Queue<CalendarWeek<Calendar>>();
    public Queue<CalendarWeek<Calendar>> Stackqueue = new Queue<CalendarWeek<Calendar>>();
    public void Getcalendar(int year, int month)
        {
            DateTime dateTime = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int currentDay = 1;
            var dayOfWeek = (int)dateTime.DayOfWeek;
        for (int i = 0; i < calendar.GetLength(0); i++)
        {
            CalendarWeek<Calendar> cal = new CalendarWeek<Calendar>();
            CalendarWeek<Calendar> StackQueue = new CalendarWeek<Calendar>();
            for (int j = 0; j < calendar.GetLength(1) && currentDay - dayOfWeek + 1 <= days; j++)
            {
                if (i == 0 && month > j)
                {
                    calendar[i, j] = 0;
                }
                else
                {
                    calendar[i, j] = currentDay - dayOfWeek + 1;
                    CalendarWeek<Calendar> calenderObj = new CalendarWeek<Calendar>(calendar[i, j]);
                    CalendarWeek<Calendar> calenderObjForStack = new CalendarWeek<Calendar>(calendar[i, j]);
                    weekQueue.Append(calenderObj);
                    StackQueue.InsertAtLast(calenderObjForStack);
                    currentDay++;
                }
            }
            weekQueue.Enqueue(cal);
            Stackqueue.Enqueue(StackQueue);
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
    public void StackImplementation(int year, int month)
    {
        int n = Stackqueue.Count;
        for (int i = 0; i < n; i++)
        {
            CalendarWeek<Calendar> StackQueue = new CalendarWeek<Calendar>();
            Stackqueue.Enqueue(StackQueue);
        }
 
        Console.WriteLine($"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month)} {year}");
        Console.WriteLine("Mon Tue Wed Thu Fri Sat Sun");
        foreach (var i in Stackqueue)
        {
            i.DisplayWeek();
        }
    }
    public void DisplayCalendarUsingQueue(int year, int month)
    {
        Console.WriteLine($"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month)} {year}");
        Console.WriteLine("Mon Tue Wed Thu Fri Sat Sun");
        foreach (var item in weekQueue)
        {
            item.DisplayWeek();
        }
    }
}


