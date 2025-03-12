using System;

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
    }
}
