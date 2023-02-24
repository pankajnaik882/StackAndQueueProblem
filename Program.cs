using System.Collections;

namespace StackAndQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("");
            LinkedList list= new LinkedList();
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30); 
            stack.Push(56);

            foreach(int i in stack)
            {
                list.Add(i);
            }
            Console.WriteLine("\nTop of stack : {0}",stack.Peek());
        }
    }
}
