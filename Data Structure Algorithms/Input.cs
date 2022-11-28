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
            PrimeNumber primeNumber = new PrimeNumber();
            primeNumber.RangePrime();
            primeNumber.printAnagramNumber();
            primeNumber.PrintNotAnagramNumbers();
        }
    }
}
