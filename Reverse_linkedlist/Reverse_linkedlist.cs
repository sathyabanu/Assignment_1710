namespace Reverse_linkedlist
{
    public class Reverse_linkedlist
    {
        static void Main(string[] args)
        {
            LinkedList<int> list= new LinkedList<int>();
            //list.AddFirst(10);
            //list.AddFirst(20);
            //list.AddFirst(30);
            //list.AddFirst(40);
            //40 30 20 10
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            //10 20 30
            for(int i=list.Count()-1;i>=0;i--)
            {
                Console.WriteLine(list.ElementAt(i));
            }
        }
    }
}
