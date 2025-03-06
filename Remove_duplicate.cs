using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_problems
{
    class Remove_duplicate
    {
        public static void entry()
        {
            int[] arr = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int n = arr.Length;
            if (n == 0) Console.WriteLine(0);

            int j = 0;
            for (int i = 1; i < n; i++)
            {
                if (arr[i] != arr[j])
                {
                    j++;
                    arr[j] = arr[i];
                }


            }
            Console.WriteLine("Array Elements are");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nUnique elment :" + (j + 1)); ;
        }
    }
}
