using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Algorithms
{
    public class PalindromeString
    {
        public void checkString(string palindrome)
        {
            Queue<char> queue = new Queue<char>();
            for(int i=palindrome.Length-1;i>=0;i--)
            {
                queue.Enqueue(palindrome[i]);
            }
            string reverseWord = "";
            while(queue.Count !=0)
            {
                reverseWord=reverseWord+queue.Dequeue();
            }
            if(palindrome.Equals(reverseWord))
            {
                Console.WriteLine("{0} is a Palindrome String : ",palindrome);
            }
            else
            {
                Console.WriteLine("{0} is not a Palindrome String : ", palindrome);
            }
        }
    }
}
