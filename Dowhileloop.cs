using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 20;

            do
            {
                Console.WriteLine("The number is greater than 10");
                count++;
            }
            while (count < 10);
        }
    }
}
