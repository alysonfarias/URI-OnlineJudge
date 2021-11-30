/*
Given two strings compare if the last digit are equals, the input is separated by " "
EX: 1232 3213
*/

using System;

namespace FitOrDontFit
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtd; i++)
            {
                string[] str = Console.ReadLine().Split(" ");
                if(str[0][str[0].Length-1] == str[1][str[1].Length - 1])
                {
                    Console.WriteLine("encaixa");
                }else
                {
                    Console.WriteLine("não encaixa");
                }
            }
        }

    }


}
