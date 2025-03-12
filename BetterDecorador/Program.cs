using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography;

namespace BetterDecorador
{
    /// <summary>
    /// Default Class program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Program start here.
        /// </summary>
        /// <param name="args">Arguments sent to the program via script run.</param>
        private static void Main(string[] args)
        {
            if (args.Length == 0)
                Console.WriteLine(Decor());
            else
                Console.WriteLine(Decor(args[0].Trim(' '), char.Parse(args[1]), int.Parse(args[2])));
        }

        /// <summary>
        /// Place at the start and end of a string 'qtdVezes' times a char.
        /// </summary>
        /// <param name="s">String to be between the char's.</param>
        /// <param name="dec">Char to be at the start and end of the string.</param>
        /// <param name="qtdVezes">How many times should the char appears.</param>
        /// <returns>Final string.</returns>
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

        /// <summary>
        /// Called when no args are sent to the program.
        /// </summary>
        /// <returns>Error message for not having arguments.</returns>
        private static string Decor()
        {
            return Decor("User did not specify args!", '=', 3);
        }
    }
}
