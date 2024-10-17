namespace Null_Reference_ex
{
   public class Program
    {
        static void Main(string[] args)
        {
           string input=null;//input is null
            try
            {
                int length = input.Length;//length property for string
                Console.WriteLine(length);//gives an exception o/p(Object reference not set to an instance of an object)
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("completed");
        }
    }
}
