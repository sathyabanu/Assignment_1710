using System.Collections.Generic;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Swapping_list
{
    public class Swapping_list
    {
        public static void swapping(int num1, int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
        public static void Main(string[] args)
        {
            swapping(5, 10);
        }
    }
}
