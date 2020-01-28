using System;
using System.Diagnostics;
using System.Linq;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5,0,6,4,7,3,8,9,1,2};
            int[] sorted_arr_asc = BubbleSort(arr);
            int[] correct_asc = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Debug.Assert(Enumerable.SequenceEqual(sorted_arr_asc, correct_asc));

            int[] correct_desc = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            int[] sorted_arr_desc = BubbleSort(arr);
            Debug.Assert(Enumerable.SequenceEqual(sorted_arr_desc, correct_desc));

        }
        static int[] BubbleSort(int[] array, bool asc = true)
        {
            bool is_sorted = false;
            while (!is_sorted)
            {
                is_sorted = true;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        is_sorted = false;
                        int latter = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = latter;
                    }
                }
            }
            if (!asc)
            {
                Array.Reverse(array);
                return array;
            }
            return array;
        }
    }
}
