namespace DSA_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack_linkedlist stack = new Stack_linkedlist();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);


            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Print Stack");
                Console.WriteLine("5. Size");
                Console.WriteLine("6. Check if Empty");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter value to push: ");
                        int value;
                        if (int.TryParse(Console.ReadLine(), out value))
                            stack.Push(value);
                        else
                            Console.WriteLine("Invalid input! Enter a valid integer.");
                        break;

                    case 2:
                        Console.WriteLine("Popped: " + stack.Pop());
                        break;

                    case 3:
                        Console.WriteLine("Top element: " + stack.Peek());
                        break;

                    case 4:
                        stack.Print();
                        break;

                    case 5:
                        Console.WriteLine("Size: " + stack.Size());
                        break;

                    case 6:
                        Console.WriteLine(stack.Isempty() ? "Stack is empty" : "Stack is not empty");
                        break;

                    case 7:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice! Please enter a valid option.");
                        break;
                }
            }
        }

    }
}
