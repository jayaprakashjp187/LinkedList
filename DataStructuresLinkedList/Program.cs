using System.Collections.Generic;

namespace DataStructuresLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose what program u want");
            Console.WriteLine("1.creating a simple linked list\n2.Adding numbers to the linkedlist\n3.create a linked list by using append\n4.Inserting a values in to a linkedlist\n5.Deleting the value in to a linkedlist");
            int choose =Convert.ToInt32(Console.ReadLine());
            switch(choose)
            {
                case 1:
                    Console.WriteLine("welcome to the creating of simple linked list");
                    LinkedList l = new LinkedList();
                    l.Insert(56);
                    l.Insert(30);
                    l.Insert(70);
                    l.Display();
                    break;
                    case 2:
                    Console.WriteLine("welcome to the creating linked list by adding numbers");
                    CustomLinkedList linkedList = new CustomLinkedList();
                    linkedList.Add(56);
                    linkedList.Add(30);
                    linkedList.Add(70);
                    linkedList.Display();
                    break;
                case 3:
                    Console.WriteLine("creating a linked list by using appending");
                    LinkedList li = new LinkedList();
                    li.Append(56);
                    li.Append(30);
                    li.Append(70);
                    li.Display();
                    break;
                 case 4:
                    Console.WriteLine("inserting a values in to a linked list");
                    LinkedList ll = new LinkedList();
                    ll.InsertAfter(30, 56, 70);
                    ll.Display();
                    break;
                 case 5:
                    CustomLinkedList c = new CustomLinkedList();
                    c.Insert(70);
                    c.Insert(30);
                    c.Insert(56);
                    c.Display();

                    c.Pop();
                    c.Display();


                    break; 
            }
        }
    }
}