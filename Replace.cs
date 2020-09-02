using System;

namespace Replace
{
    class Replace
    {
        static void Main(string[] args)
        {
            String one = "Hello World!";
            Console.WriteLine(one);

            one = one.Replace("Hello", "Greetings");
            Console.WriteLine(one);
        }
    }
}
