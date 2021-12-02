using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int coroa = 0, cara = 0;
            var rn = new Random();
            for (int i = 0; i < 100000000; i++)
            {
                int coroaOuCara = rn.Next(1, 3);
                if(coroaOuCara == 1)
                {
                    coroa++;
                }
                else{
                    cara++;
                }
            }
            Console.WriteLine("Cara: " + cara + " Coroa: " + coroa);
        }
    }
}
