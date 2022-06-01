using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Programs
{
    public class InsertionSort
    {
        public void InsertionSorting(string[] array)
        {
            int i, j;
            //Initially i is kept at 1 and j is kept at 0 to compare 
            for (i = 1; i < array.Length; i++)
            {
                string value = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }
        }
    }
}
