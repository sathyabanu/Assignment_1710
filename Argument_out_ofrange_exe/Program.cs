namespace Argument_out_ofrange_exe
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1,2,3,4,5};
            try
            {
                //Console.WriteLine(list[2]);//3
                Console.WriteLine(list[8]);//index 8 is not present so it show exception
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);//Index was out of range. Must be non-negative and less than the size of the collection. (Parameter 'index')
            }
        }
    }
}
