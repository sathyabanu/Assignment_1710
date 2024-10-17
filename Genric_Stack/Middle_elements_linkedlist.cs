namespace Middle_elements_linkedlist
{
    public class Middle_elements_linkedlist
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("I");
            list.AddLast("N");
            list.AddLast("D");
            list.AddLast("I");
            list.AddLast("A");
            int total = list.Count();
            Console.WriteLine(list.ElementAt(total / 2));

        }
        }
    }