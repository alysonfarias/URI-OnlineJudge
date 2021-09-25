/* Objective 
54321
5432
543
54
5

*/

using System;

public class Program
{
    public static void Main()
    {
        for (int linha = 0; linha <= 5; linha++)
        {
            for (int coluna = 4; coluna >= 0; coluna--)
            {
                if ( coluna < linha )
                {
                    break;
                }
                Console.Write( coluna + 1);
            }
            Console.WriteLine();
        }
    }
}
