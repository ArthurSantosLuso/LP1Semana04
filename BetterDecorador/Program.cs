using System;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor("Good Morning!", '*'));
            Console.WriteLine(Decor("Good Evening!", '.'));
        }

        private static string Decor(string s, char dec)
        {
            return $"{dec}{dec}{dec} {s} {dec}{dec}{dec}";
        }
    }
}
