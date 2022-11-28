using System.Net.Http.Headers;

namespace Data_Structure_Algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your String Which You Want to Check : ");
            string Word  = Console.ReadLine();

            PalindromeString palindromeString = new PalindromeString();
            palindromeString.checkString(Word);
        }
    }
}