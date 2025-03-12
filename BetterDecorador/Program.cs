using System;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor(args[0].Trim(' '), char.Parse(args[1]), int.Parse(args[2])));
        }

        private static string Decor(string s, char dec, int qtdVezes)
        {
            string textoFinal = "";

            for (int i = 0; i < qtdVezes; i++)
            {
                textoFinal += $"{dec}";
            }

            textoFinal += $" {s} ";

            for (int j = 0; j < qtdVezes; j++)
            {
                textoFinal += $"{dec}";
            }

            return textoFinal;
        }
    }
}
