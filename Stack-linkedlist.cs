using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp
{
    public class Stack_linkedlist
    {
        private Node top;
        private int size;

        public Stack_linkedlist()
        {
            top = null;
            size = 0;
        }

        public void Push(int item)
        {
            Node newnode = new Node(item);
            newnode.next = top;
            top = newnode;
            size++;
        }

        public int Pop()
        {
            if (top == null)
            {
                Console.WriteLine("No element to pop");
                return -1;
            }
            int pop_value = top.data;
            top = top.next;
            size--;
            return pop_value;
        }

        public int Peek()
        {
            if (top == null)
            {
                Console.WriteLine("stack is empty");
                return -1;
            }

            return top.data;
        }

        public bool Isempty()
        {
            return top == null;
        }

        public int Size()
        {
            return size;
        }

        public void Print()
        {
            if (top == null)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Node curr = top;
            while (curr != null)
            {
                Console.Write(curr.data + " -> ");
                curr = curr.next;
            }
            Console.WriteLine();
        }
    }

    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;

        }
    }
}
