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
            Console.WriteLine("\n Enter Word to Search : ");
            int number = Convert.ToInt32(Console.ReadLine());
            OrderedList orderedList = new OrderedList();
            orderedList.OrderedLinkedList(number);
        }
    }
}
