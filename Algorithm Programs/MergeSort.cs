using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Programs
{
    public class MergeSort
    {
        public void Merging(int left, int mid, int right)
        {
            int[] numbers = { 24, 56, 78, 34, 12, 58, 90 };
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
                temp[pos++] = numbers[left++];
            while (mid <= right)
                temp[pos++] = numbers[mid++];
            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
            foreach(var elements in numbers)
            {
                Console.WriteLine(elements);
            }
        }
        public void MergeSorting(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSorting(numbers, left, mid);
                MergeSorting(numbers, (mid + 1), right);
                Merging(left, (mid + 1), right);
            }
        }

    }
}
