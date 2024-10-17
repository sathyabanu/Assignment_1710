namespace Overflow_exception
{
    public class Program
    {
        static void Main(string[] args)
        {
            int min = int.MinValue;
            try
            {   
                int results = min + 1;
            }
            catch(OverflowException ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
