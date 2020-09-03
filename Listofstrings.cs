using System;
using System.Collections.Generic;
using System.Text;

namespace Loops2
{
    class Class2
    {
        static void Main(String[] args)
        {
            var animals = new List<string> { "monkey", "tiger", "lion", "cheeta" };

            animals.Add("dog");
            animals.Add("cat");
            animals.Remove("monkey");
            animals.Add("elephant");
            foreach(String i in animals)
            {
                Console.WriteLine($"Hey its a {i.ToUpper()}");
            }

            Console.WriteLine(animals[3]);

        }

    }
}
