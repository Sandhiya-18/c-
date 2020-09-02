using System;

namespace ULcase
{
    class Program
    {
        static void Main(string[] args)
        {
            String one = "Hello World!";
            Console.WriteLine(one);

            one = one.Replace("Hello", "Greetings");
            Console.WriteLine(one);
            Console.WriteLine(one.ToLower());
            Console.WriteLine(one.ToUpper());
        }
    }
}
