using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLinkedList
{
    internal class LinkedList
    {
        private Node head;
        public void Insert(int data)
        {
            Node newNode = new Node(data);
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
        public void Append(int data)
        {
            Node newNode = new Node(data);
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
        

        public void InsertAfter(int value, int afterValue, int beforeValue)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current != null)
                {
                    if (current.Data == afterValue && current.Next != null && current.Next.Data == beforeValue)
                    {
                        newNode.Next = current.Next;
                        current.Next = newNode;

                        break;
                    }
                    
                    current = current.Next;
                }
            }
        }
      
        




        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
            Console.WriteLine();

        }

    }
}
