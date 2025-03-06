using System.Transactions;

namespace DSA_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circularll list = new Circularll();

            list.Add_last(10);
            list.Add_last(20);
            list.Add_last(30);
            list.Add_last(40);
            list.Add_last(50);

            int choice, value;

            while (true)
            {   
                Console.WriteLine("\n--- Doubly Linked List ---");
                Console.WriteLine("1. Add First");
                Console.WriteLine("2. Add Last");
                Console.WriteLine("3. Add at index");
                Console.WriteLine("4. Remove First");
                Console.WriteLine("5. Remove last");
                Console.WriteLine("6. Remove at index");
                Console.WriteLine("7. Print");
                Console.WriteLine("8. Exit");

                Console.WriteLine("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter value to add at the beginning: ");
                        value = Convert.ToInt32(Console.ReadLine());
                        list.Add_first(value);
                        break;
                    case 2:
                        Console.WriteLine("Enter value to add at the end: ");
                        value = Convert.ToInt32(Console.ReadLine());
                        list.Add_last(value);
                        break;
                    case 3:
                        Console.WriteLine("Enter value to add : ");
                        value = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter index : ");
                        int index = int.Parse(Console.ReadLine());
                        list.Add_at_index(index, value);
                        break;

                    case 4:
                        list.Remove_first();
                        break;
                    case 5:
                        list.Remove_last();
                        break;
                    case 6:
                        int remove_index = int.Parse(Console.ReadLine());
                        list.Remove_at_index(remove_index);
                        break;
                    case 7:
                        list.Print();
                        break;
                    case 8:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice,please try again.");
                        break;
                }
            }
        }
    }
}
