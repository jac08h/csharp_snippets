using System;
using System.Diagnostics;
using System.Linq;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5,0,6,4,7,3,8,9,1,2 };
            int[] sorted_arr_asc = BubbleSort(arr);
            Debug.Assert(isSorted(sorted_arr_asc));

            int[] sorted_arr_desc = BubbleSort(arr, false);
            Debug.Assert(isSorted(sorted_arr_desc, false));

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

        static bool isSorted(int[] array, bool asc = true)
        {
            for (int i = 0; i<array.Length-1; i++)
            {
                if (asc) {
                    if (array[i] > array[i + 1]) { return false; }
                }
                else  // descending
                {
                    if (array[i] < array[i+1]) { return false; }
                    }
            }
            return true;
        }
    }
}
