namespace DSA_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doublyll list = new Doublyll();

            list.Addlast(10);
            list.Addlast(20);
            list.Addlast(30);
            list.Addlast(40);
            list.Addlast(50);

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
                        list.Addfirst(value);
                        break;
                    case 2:
                        Console.WriteLine("Enter value to add at the end: ");
                        value = Convert.ToInt32(Console.ReadLine());
                        list.Addlast(value);
                        break;
                    case 3:
                        Console.WriteLine("Enter value to add : ");
                        value = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter index : ");
                        int index = int.Parse(Console.ReadLine());
                        list.Add_at_index(index, value);
                        break;

                    case 4:
                        list.Removefirst();
                        break;
                    case 5:
                        list.Removefirst();
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
