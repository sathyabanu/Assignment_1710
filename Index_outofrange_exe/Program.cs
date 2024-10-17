namespace Index_outofrange_exe
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] num = new int[5];
                num[0] = 10;
                num[1] = 20;
                num[2] = 30;
                num[3] = 40;
                num[4] = 50;
                Console.WriteLine(num[5]);//
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
