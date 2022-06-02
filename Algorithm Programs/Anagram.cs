using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Programs
{
    public class Anagram
    {
        public void AnagramDetection()
        {
            //Entering the first and second string to check
            Console.WriteLine("Enter first string");
            string first = Console.ReadLine();
            Console.WriteLine("Enter second string");
            string second = Console.ReadLine();
            //Now Convert string to character array  
            char[] firstChar = first.ToUpper().ToCharArray();
            char[] secondChar = second.ToUpper().ToCharArray();
            //Sort array means it will sort the aray according to their ASCII value
            Array.Sort(firstChar);
            Array.Sort(secondChar);
            //Again converting the array into string
            string firstString1 = new string(firstChar);
            string secondString2 = new string(secondChar);
            if (firstString1 == secondString2)
            {
                Console.WriteLine("Both the strings are anagrams!");

            }
            else
            {
                Console.WriteLine("Both the strings are not anagrams!");
            }
        }
    }
}
