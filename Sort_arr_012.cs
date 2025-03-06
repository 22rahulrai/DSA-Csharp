using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_problems
{
    class Sort_arr_012
    {
        public static void entry()
        {
            int[] arr = { 2, 0, 2, 1, 1, 0 };

            Console.WriteLine("Array before sorting");
            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }

            int n = arr.Length;
            int c0 = 0, c1 = 0, c2 = 0;

            int i = 0;

            // Count occurrences of 0, 1, and 2
            for (i = 0; i < n; i++)
            {
                if (arr[i] == 0) c0++;
                else if (arr[i] == 1) c1++;
                else if (arr[i] == 2) c2++;
            }

            // Overwrite array with sorted values
            i = 0;
            for (; i < c0; i++) arr[i] = 0;
            for (; i < c0 + c1; i++) arr[i] = 1;
            for (; i < c0 + c1 + c2; i++) arr[i] = 2;

            Console.WriteLine("\nArray after sorting");
            foreach(int a in arr)
            {
                Console.Write(a+" ");
            }
        }
    }
}
