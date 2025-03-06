using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_problems
{
    class Majority_Element
    {
        public static void entry()
        {
            int[] arr = { 2, 2, 1, 1, 1, 2, 2 };

            Console.WriteLine("Array ");
            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }
            Dictionary<int, int> map = new Dictionary<int, int>();

            // Count occurrences of each element
            foreach (int num in arr)
            {
                if (map.ContainsKey(num))
                    map[num]++;
                else
                    map[num] = 1;
            }

            int n = 0;
            int threshold = arr.Length / 2;

            // Find the majority element
            foreach (var key in map.Keys)
            {
                if (map[key] > threshold)
                {
                    n = key;
                    break; // No need to continue once the majority element is found
                }
            }

            Console.WriteLine($"\nMajority Elemnt :{n}");
        }

    }
}
