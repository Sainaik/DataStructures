using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_DataStructe
{
    public class Queue
    {
        Node head = null;

        internal void Enqueue(int data)
        {
            Node node = new Node(data);

            if(head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = node;
                Console.WriteLine($"{node.data} is inserted in Queue");

            }
        }

        internal void Display()
        {
            Node temp = this.head;

            if(temp == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                while(temp!=null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                   
                }
            }
        }

        internal void DeQueue()
        {

            Node temp = this.head;

            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }

            int data = temp.data;

            Console.WriteLine(data + " is Dequeued ");

            head = temp.next;


            
            
        }
    }
}
