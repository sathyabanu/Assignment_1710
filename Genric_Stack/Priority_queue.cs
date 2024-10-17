namespace Priority_queue
{
    public class Priority_queue
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> sorted = new SortedDictionary<int, string>();
            sorted.Add(10, "aaaa");
            sorted.Add(1, "aaaa");
            sorted.Add(12, "fffff");
            sorted.Add(2, "bbbb");
            sorted.Add(3, "cccc");//it will sorted based on keys and values
            PriorityQueue<int, string> priority = new PriorityQueue<int, string>();
            {
                foreach(var item in sorted)
                {
                    priority.Enqueue(item.Key, item.Value);
                }
                while (priority.Count > 0)
                {
                    //var result=priority.Dequeue();
                    //Console.WriteLine(result);
                    int key = priority.Dequeue();
                    string value = sorted[key];
                    Console.WriteLine(key + ":" + value);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
                }   
            }
        }
    }
}
