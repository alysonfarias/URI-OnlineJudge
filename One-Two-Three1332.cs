/*Your little brother has just learnt to write one, two and three, in English.
 He has written a lot of those words in a paper, your task is to recognize them. 
Note that your little brother is only a child, so he may make small mistakes: for each word, there might be at most one wrong letter.
 The word length is always correct. It is guaranteed that each letter he wrote is in lower-case, and each word he wrote has a unique interpretation.
 
 https://www.beecrowd.com.br/judge/en/problems/view/1332
*/

using System;

namespace OneTwoThree1332
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int inputQtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputQtd; i++)
            {
                str = Console.ReadLine();
                Console.WriteLine(str.Length);
                if (str.Length <= 3 ) // can be [one] or [two] 
                {
                       if((str[0] == 't' && str[1] == 'w') || (str[0] == 't' && str[2] == 'o') || (str[1] == 'w' && str[2] == 'o'))
                        {
                        Console.WriteLine('2');
                        }
                        else
                        {
                        Console.WriteLine('1');
                        }
                }
                else // can only be three
                {
                    Console.WriteLine('3');
                }
            }
        }
    }
}
