using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_problems
{
    class Stock_buy_sell
    {
        public static void entry()
        {
            
            int[] arr = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine("Array ");
            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }
            int n = arr.Length;
            int min = arr[0];
            int res = 0;

            for (int i = 1; i < n; i++)
            {
                min = Math.Min(arr[i], min);
                res = Math.Max(res, arr[i] - min);
            }

            Console.WriteLine("\nMax Profit: "+res);
            //return res;
        }
    }
}
