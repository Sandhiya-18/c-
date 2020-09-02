using System;

namespace Trim
{
    class Trim
    {
        static void Main(string[] args)
        {
            String Name = "     sandhiya     ";
            Console.WriteLine($"[***{Name}***]");
            String Name2 = Name.TrimStart();
            Console.WriteLine($"[***{Name2}***]");
            String Name3 = Name.TrimEnd();
            Console.WriteLine($"[***{Name3}***]");
            String Name4 = Name.Trim();
            Console.WriteLine($"[***{Name4}***]");

        }
    }
}
