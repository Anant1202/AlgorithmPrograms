using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Programs
{
    public class Permutation
    {
        public static void Permute(string s, int start, int end)
        {
            if (start == end)
            {
                Console.WriteLine("\ns");
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    s = (Swap(s, start, i));
                    //Recursion 
                    //start + 1 is used here to fix the first character
                    Permute(s, start + 1, end);
                    //Backtrack
                    s = Swap(s, start, i);
                }
            }

        }
        public static string Swap(string word, int start, int end)
        {
            char temp;
            char[] array = word.ToCharArray();
            temp = array[start];
            array[start] = array[end];
            array[end] = temp;
            string s = new string(array);
            return s;

        }
    }
}
