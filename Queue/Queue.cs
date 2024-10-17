namespace Queue
{
    public class Queue
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            Queue<int> queue = new Queue<int>();
            foreach (int item in list)
            {
                queue.Enqueue(item);
            }
            foreach(int item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
