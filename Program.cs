using System;
using System.Collections;

namespace StackAndQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Queue q1 = new Queue();
            q1.Enqueue(56);
            q1.Enqueue(30);
            q1.Enqueue(70);

            foreach (int i in q1)
            {
                list.Add(i);
            }
            Console.WriteLine("\nTop of the stack : {0}", q1.Peek());
            Console.WriteLine("************************");

            q1.Dequeue();
            foreach (int i in q1)
            {
                list.Add(i);
            }
            Console.WriteLine("\nTop of the stack : {0}", q1.Peek());
            Console.WriteLine("************************");

            q1.Dequeue();
            foreach (int i in q1)
            {
                list.Add(i);
            }
            Console.WriteLine("\nTop of the stack : {0}", q1.Peek());
            Console.WriteLine("************************");

            q1.Dequeue();
            foreach (int i in q1)
            {
                list.Add(i);
            }
            Console.WriteLine("\nTop of the stack : {0}", q1.Peek());
            Console.WriteLine("************************");
            Console.WriteLine("Queue was Empty");
        }

    }
}
