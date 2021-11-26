/*
Some texts contain hidden messages. In the context of this problem, the hidden message of a text is composed of the first letter from each word in the text,
in the order they appear.
Given a text consisting of only lowercase letters and spaces, return the hidden message. 
A word is a maximal sequence of consecutive letters. There may be multiple spaces between words.
The text may start in spaces, end in spaces or even contain spaces only.
_
RUNTIME:
0.200s
FILE SIZE:
801 Bytes
 
*/



using System;

namespace HiddenMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtd; i++)
            {
                string str = Console.ReadLine();
                bool flag = true;
                string result = "";
                for (int  k = 0; k < str.Length; k++)
                {
                    if(str[k] != ' ' && flag == true)
                    {
                        //Console.Write(str[k]);
                        result += str[k];
                        flag = false;
                    } else if(str[k] == ' ')
                    {
                        flag = true;
                    }

                }
                Console.WriteLine(result);
            }
        }
    }
}
