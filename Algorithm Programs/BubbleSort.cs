using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Programs
{
    public class BubbleSort
    {
        public void BubbleSorting()
        {
            int[] arr = { 56, 42, 90, 78, 122, 39 };
            int temp;
            //i end value should be 1 less than the array length because it it comparing the elements in pair
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (int elements in arr)
            {
                Console.WriteLine(elements);
            }
        }
    }
}
