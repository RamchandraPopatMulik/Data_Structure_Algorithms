using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data_Structure_Algorithms.Node1;

namespace Data_Structure_Algorithms
{
    public class Input
    {
       public void UserInputForProgram()
        {
            Console.WriteLine("Enter the Year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month : ");
            int month = Convert.ToInt32(Console.ReadLine());
            calender calender = new calender();
            calender.Getcalendar(year,month);
            calender.PrintCalendar(year,month);
            calender.DisplayCalendarUsingQueue(year,month);
            calender.StackImplementation(year,month);
        }
    }
}
