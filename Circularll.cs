using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp
{
    class Circularll
    {
        public Node head = null;
        public Node tail = null;

        public void Add_first(int data)
        {
            Node newnode = new Node(data);

            if (head == null)
            {
                head = newnode;
                tail = newnode;
                newnode.next = head;
            }
            else
            {
                newnode.next = head;
                head = newnode;
                tail.next = head;
            }
        }

        public void Add_last(int data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                Add_first(data);
            }
            else
            {
                tail.next = newnode;
                tail = newnode;
                tail.next = head;
                //newnode.next = head;
                //tail = newnode;
            }
        }

        public void Add_at_index(int index, int data)
        {
            if (index < 0)
            {
                Console.WriteLine("Index cannot be negative");
                return;
            }
            else if (index == 0)
            {
                Add_first(data);
                return;
            }

            Node newnode = new Node(data);
            Node curr = head;
            int count = 0;

            while (count < index - 1 && curr.next != head)
            {
                curr = curr.next;
                count++;
            }

            // If we stopped before reaching the required index, it means index is out of bounds
            if (count < index - 1)
            {
                Console.WriteLine("Index is out of range");
                return;
            }

            newnode.next = curr.next;
            curr.next = newnode;
        }

        public void Remove_first()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty, cannot remove first element");
                return;
            }
            else if (head == tail) //only one node in list
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.next;
                tail.next = head;
                //head.next = null;
            }
        }

        public void Remove_last()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty, cannot remove first element");
                return;
            }
            else if (head == tail) //only one node in list
            {
                head = null;
                tail = null;
            }
            else
            {
                Node curr = head;
                while (curr.next != tail)
                {
                    curr = curr.next;
                }
                curr.next = tail.next;
                tail = curr;
            }
        }

        public void Remove_at_index(int index)
        {
            if (index < 0)
            {
                Console.WriteLine("Index cannot be negative");
                return;
            }
            else if (head == tail) //only one node in list
            {
                head = null;
                tail = null;
            }
            else if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node curr = head;
            int currindex = 0;
            while (curr != null && currindex < index - 1)
            {
                curr = curr.next;
                currindex++;
                if (curr == head)
                {
                    break;
                }
            }

            if (curr != null && curr.next != null)
            {
                curr.next = curr.next.next;
            }
            else
            {
                Console.WriteLine("index is out of range");
            }
        }


        public void Print()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node curr = head.next;
            Console.Write(head.data + " ");
            while (curr != head)
            {
                Console.Write(curr.data + " ");
                curr = curr.next;
            }
            Console.WriteLine();
        }
    }

    public class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            this.data = d;
            this.next = null;
        }
    }
}

