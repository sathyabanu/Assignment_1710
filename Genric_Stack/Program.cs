namespace Genric_Stack
{
   public class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine(stack.Count());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());

            ////for checking all items
            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}
        }
    }
}
