using System;

namespace DeciLongShort
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integer is {min} to {max}");

            long max2 = long.MaxValue;
            long min2 = long.MinValue;
            Console.WriteLine($"The range of Long is {min2} to {max2}");

            short max3 = short.MaxValue;
            short min3 = short.MinValue;
            Console.WriteLine($"The range of Short is {min3} to {max3}");

            decimal max4 = decimal.MaxValue;
            decimal min4 = decimal.MinValue;
            Console.WriteLine($"The range of Decimals is {min4} to {max4}");
        }
    }
}
