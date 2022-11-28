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
            Console.WriteLine("Enter the number of elements in BST :");
            int elements = Convert.ToInt32(Console.ReadLine());
            BSTNo bSTNo = new BSTNo();
            bSTNo.NumberOfTree(elements);
        }
    }
}
