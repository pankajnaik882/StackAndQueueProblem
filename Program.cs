using System.Collections;

namespace StackAndQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list= new LinkedList();
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30); 
            stack.Push(56);

            foreach (int i in stack)
            {
                list.Add(i);
            }
            Console.WriteLine("\nTop of the stack : {0}",stack.Peek());
            Console.WriteLine("********************");
           
            stack.Pop();

            foreach (int i in stack)
            {
                list.Add(i);
            }
            Console.WriteLine("\nTop of the stack : {0}", stack.Peek());
            Console.WriteLine("********************");


            stack.Pop();

            foreach (int i in stack)
            {
                list.Add(i);
            }
            Console.WriteLine("\nTop of the stack : {0}", stack.Peek());
            Console.WriteLine("********************");


            foreach (int i in stack)
            {
                list.Add(i);
            }
            stack.Pop();
            Console.WriteLine("Stack Was Empty");
            Console.WriteLine("********************");


        }

    }
}
