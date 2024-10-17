namespace Remove_duplicates
{
    public class Remove_duplicates
    {
        static void Main(string[] args)
        {
           List<int> list= new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(2);
            list.Add(3);
            HashSet<int> set = new HashSet<int>(list);
            {
                foreach(var item in set)
                {
                    Console.WriteLine(item);
                }
            }


        }
    }
}
