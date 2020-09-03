using System;
using System.Collections.Generic;
using System.Text;

namespace Loops2
{
    class Class1
    {
        static void Main(String[] args)
        {
            var animals = new List<string> { "monkey", "tiger", "lion", "cheeta" };

            animals.Add("dog");
            animals.Add("cat");
            animals.Remove("monkey");
            animals.Add("elephant");
            animals.Sort();
            foreach (String i in animals)
            {
                Console.WriteLine($"Hey its a {i.ToUpper()}");
            }

            var index = animals.IndexOf("elephant");
            Console.WriteLine($"Found the index of elephant at {index}");
        }
        }
    }
