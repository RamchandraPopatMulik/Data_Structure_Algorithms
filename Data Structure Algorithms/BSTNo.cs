using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Algorithms
{
    public class BSTNo
    {
        public int NumberOfTree(int elements)
        {
            if(elements <=1)
            {
                return 1;
            }
            int sum = 0;
            int left=0;
            int right=0;
           
            for(int i=1;i<=elements;i++)
            {
                left=NumberOfTree(i-1);
                right = NumberOfTree(elements-i);
                sum=sum+(left*right);
            }
            return sum;
        }
    }
}
