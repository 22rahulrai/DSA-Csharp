using Array_problems;

namespace DSA_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            

            while (true)
            {
                Console.WriteLine("Select the Problem");
                Console.WriteLine("1. Find the Missing Number in an Array");
                Console.WriteLine("2. Remove duplicate from sorted Array");
                Console.WriteLine("3. Sort and arry of 0's 1's and 2's");
                Console.WriteLine("4. Find the Majority Element");
                Console.WriteLine("5. Stock Buy and sell ");
                Console.WriteLine("6. Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Missing_no.entry();
                        break;
                    case 2:
                        Remove_duplicate.entry();
                        break;
                    case 3:
                        Sort_arr_012.entry();
                        break;
                    case 4:
                        Majority_Element.entry();
                        break;
                    case 5:
                        Stock_buy_sell.entry();
                        break;
                    case 6:
                        Console.WriteLine("exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            Console.ReadKey();
        }

    }
}
