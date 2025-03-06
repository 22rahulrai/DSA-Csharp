using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp
{
    class Doublyll
    {
        public dlnode head;
        public dlnode tail;

        public Doublyll()
        {
            head = null;
            tail = null;
        }

        public void Addfirst(int value)
        {
            dlnode newnode = new dlnode(value);

            if (head == null)
            {
                head = newnode;
                tail = newnode;
            }
            else
            {
                newnode.next = head;
                head.prev = newnode;
                head = newnode;
            }
        }

        public void Addlast(int value)
        {
            dlnode newnode = new dlnode(value);

            if (tail == null) //if list is empty
            {
                head = newnode;
                tail = newnode;
            }
            else
            {
                tail.next = newnode;
                newnode.prev = tail;
                tail = newnode;
            }
        }

        public void Add_at_index(int index, int value)
        {
            if (index < 0)
            {
                Console.WriteLine("Invalid index.");
                return;
            }
            else if (index == 0)
            {
                Addfirst(value);
            }

            dlnode newnode = new dlnode(value);
            dlnode curr = head;
            int count = 0;
            while (curr != null && count < index - 1)
            {
                curr = curr.next;
                count++;
            }

            if (curr == null)
            {
                Console.WriteLine("Index out of bounds.");
                return;
            }
            newnode.next = curr.next;
            newnode.prev = curr;

            if (curr.next != null)
            {
                curr.next.prev = newnode;
            }
            else
            {
                tail = newnode;
            }
            curr.next = newnode;

        }

        public void Removefirst()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty, cannot remove first element");
                return;
            }

            if (head == tail) //only one node in list
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.next;
                head.prev = null;
            }
        }

        public void Removelast()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty, cannot remove last element");
                return;
            }
            if (head == tail) //only one node in list
            {
                head = null;
                tail = null;
            }
            else
            {
                tail = tail.prev;
                tail.next = null;
            }
        }

        public void Remove_at_index(int index)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty, cannot remove.");
                return;
            }

            if (index < 0)
            {
                Console.WriteLine("Invalid index.");
                return;
            }
            else if (index == 0)
            {
                Removefirst();
                return;
            }

            dlnode curr = head;
            int count = 0;

            while (curr != null && count < index)
            {
                curr = curr.next;
                count++;
            }
            curr.next.prev = null;

            curr.next = curr.next.next;
            curr.next.next.prev = curr;
        }

        public void Print()
        {
            dlnode curr = head;

            Console.WriteLine("\nLinked-list is:");
            while (curr != null)
            {
                Console.Write(curr.value + " ");
                curr = curr.next;
            }
            Console.WriteLine();
        }
    }

    public class dlnode
    {
        public int value;
        public dlnode next;
        public dlnode prev;

        public dlnode(int value)
        {
            this.value = value;
            next = null;
            prev = null;
        }
    }
}

