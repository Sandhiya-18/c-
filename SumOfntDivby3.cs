using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Loops2
{
    class Class1
    {
        static void Main(String[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                if(i%3 == 0)
                {
                    sum = sum + i;
                }

            }
            Console.WriteLine($"The sum is {sum}.");
        }
    }
}
