using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLinkedList
{
    internal class CustomLinkedList
    {
        private Node head;

        public void Add(int value)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        public void Insert(int value)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
        }

        public void Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty. Cannot perform pop operation.");
                return;
            }

            head = head.Next;
        }
        public void InsertTheValue(int value)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void PopLast()
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty. Cannot perform popLast operation.");
                return;
            }

            if (head.Next == null)
            {
                head = null;
                return;
            }

            Node current = head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }
            current.Next = null;
        }


        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + "->");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}
