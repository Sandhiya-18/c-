using System;

namespace StringSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            String Song = "My Last made me feel like i will never try again";
            Console.WriteLine(Song.Contains("Last"));
            Console.WriteLine(Song.Contains("like"));
            Console.WriteLine(Song.StartsWith("like"));
            Console.WriteLine(Song.StartsWith("My"));

        }
    }
}
