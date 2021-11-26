/*
Implement a program Combiner that takes two Strings as parameters and combines them, alternating letters, starting with the first letter of the first String,
followed by the first letter of the second String, then second letter of first String, etc. 

The remaining letters of the longer String are then appended to the end of the combination String and this combination String is returned.
https://www.beecrowd.com.br/judge/en/problems/view/1238
*/

using System;

namespace Combiner
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = int.Parse(Console.ReadLine());

            while (qtd-- > 0)
            {
                args = Console.ReadLine().Split(' ');

                for (int j = 0; j < args[0].Length || j < args[1].Length; j++)
                {
                    if (j < args[0].Length)
                    {
                        Console.Write(args[0][j]);
                    }
                    if (j < args[1].Length)
                    {
                        Console.Write(args[1][j]);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
