using System;
//Paulinho have again in your hands another problem. Now the teacher asked him to make a new program
//to verify from two big numbers A and B, if B corresponds to the last digit of A.
namespace FitOrDontFit
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtd; i++)
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();

                if(str1[str1.Length -1].Equals(str2[str2.Length-1]))
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
