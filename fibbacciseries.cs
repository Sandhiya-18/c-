using System;
using System.Collections.Generic;
using System.Text;

namespace Loops2
{
    class Class1
    {
        static void Main(string[] args)
        {
            var fibbo = new List<int> { 1, 1 };

            while (fibbo.Count < 20)
            {
                var previous1 = fibbo[fibbo.Count - 1];
                var previous2 = fibbo[fibbo.Count - 2];
                fibbo.Add(previous2 + previous1);
            }
            foreach (var i in fibbo)
                {
                Console.WriteLine(i);
            }


        }
    }
}
