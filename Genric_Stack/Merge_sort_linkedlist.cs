namespace Merge_sort_linkedlist
{
    public class Merge_sort_linkedlist
    {
        static void Main(string[] args)
        {
            LinkedList<int> list1 = new LinkedList<int>();
            LinkedList<int> list2= new LinkedList<int>();
            list1.AddLast(1);
            list1.AddLast(2);
            list1.AddLast(3);
            list1.AddLast(4);
            list2.AddLast(11);
            list2.AddLast(12);
            list2.AddLast(13);
            foreach(int i in list1)
            {
                //Console.WriteLine(i);
            } 
           foreach(int i in list2.Reverse())
            {
                //Console.WriteLine(i);
            }
           LinkedList<int> list3= new LinkedList<int>();
            //add list1 values in list3
            foreach(var num in list1)
            {
                list3.AddLast(num);
            }
            //add list2 values in list3
            foreach(var num in list2)
            {
                list3.AddLast(num);
            }
            
            foreach(var num in list3)
            {
                Console.WriteLine(num);
            }
            

        }
    }
}
