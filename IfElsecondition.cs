using System;

namespace Ifcondition
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 6;
            if(a + b > 10 && a==b)
            
            {
                Console.WriteLine("The result is greater than 10");
                Console.WriteLine("The first no. is equals to the second no.");

            }
            else
            {
                Console.WriteLine("The result is not greater than 10");
                Console.WriteLine(" or The first no. is not equals to the second no.");
                
            }
        }
    }
}
