using System;


public class Missing_no
{
    public static void entry()
    {
        int[] nums = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
        int n = nums.Length;
        int xorResult = 0;

        // XOR all numbers from 0 to n
        for (int i = 0; i <= n; i++)
        {
            xorResult ^= i;
        }

        // XOR all elements in the nums array
        foreach (int num in nums)
        {
            xorResult ^= num;
        }

        Console.WriteLine("Array: ");
        foreach (int i in nums)
        {
            Console.Write(i + " ");
        }
        // The missing number will be the result of XOR
        Console.WriteLine("\nMissing no: " + xorResult);
    }

}
