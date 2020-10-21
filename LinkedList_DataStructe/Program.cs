using Microsoft.VisualBasic.FileIO;
using System;

namespace LinkedList_DataStructe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList list = new LinkedList();
            list.Add(10);
            list.Add(5);
            list.Add(7);
            list.Add(8);
            list.Add(1);
            list.Display();

            //list.DeleteAfterElement(30);
            //list.inserAt(35, 2);
            //list.Display();

            list.head = list.ListSort(list.head);
            list.Display();
            //list.DeleteAtPosition(2);
            //list.Display();

            //list.DeleteAtPosition(1);
            //list.Display();

            //list.DeleteAtEnd();

            //list.Display();

            //list.Search(10);

            //Stack stack = new Stack();
            //stack.Push(10);
            //stack.Push(20);
            //stack.Peek();

            //Queue queue = new Queue();
            //queue.Enqueue(10);
            //queue.Enqueue(20);

            //queue.Enqueue(44);

            //queue.Display();

            //queue.DeQueue();

            //queue.Display();


        }
    }
}
