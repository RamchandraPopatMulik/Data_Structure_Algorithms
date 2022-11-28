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
            Console.WriteLine("Enter the number to search:");
            string searchValue = Console.ReadLine();
            SearchNumber searchNumber = new SearchNumber();
            searchNumber.SearchData(searchValue);
            searchNumber.Display();
        }
    }
}
