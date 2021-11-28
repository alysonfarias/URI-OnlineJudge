/*
We have some words and we want to right justify them, that is, align them to the right. 
Create a program that reads a word and print it all right justified, in the same order as they appear in the input.

https://www.beecrowd.com.br/judge/en/problems/view/1273
*/

using System;

namespace Justifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd;
            do
            {
                qtd = int.Parse(Console.ReadLine());
                if (qtd == 0)
                {
                    break;
                }
                string largestStr = "";
                string[] tests = new string[qtd];

                for (int i = 0; i < qtd; i++)
                {
                    string str = Console.ReadLine();
                    tests[i] = str;
                    if (str.Length > largestStr.Length)
                    {
                        largestStr = str;
                    }
                }
                for (int i = 0; i < tests.Length; i++)
                {
                    if (tests[i].Length < largestStr.Length)
                    {
                        string blankSpaces = multiplier(largestStr.Length - tests[i].Length);
                        Console.Write(blankSpaces);

                    }
                    Console.WriteLine(tests[i]);
                }
                Console.WriteLine();
            }
            while (qtd != 0);

                
        }

        public static string multiplier(int x)
        {
            string str = "";
            for (int i = 0; i < x; i++)
            {
                str += " ";
            }
            return str;
        }
    }
}
