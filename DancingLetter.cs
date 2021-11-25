/* A sentence is called dancing if its first letter is uppercase and the case of each subsequent letter is the opposite of the previous letter.
 Spaces should be ignored when determining the case of a letter. For example, "A b Cd" is a dancing sentence because the first letter ('A') is uppercase, 
the next letter ('b') is lowercase, the next letter ('C') is uppercase, and the next letter ('d') is lowercase.
*/
using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
                Boolean isToUpper = true;
                string dancingStr = "this is a dancing sentence";
                
            for (int i = 0; i < dancingStr.Length; i++)
            {
                if (dancingStr[i] != ' ')
                {
                    if (isToUpper)
                    {
                        //dancingStr[i] = dancingStr[i].ToString().ToUpper();
                        Console.Write(dancingStr[i].ToString().ToUpper());
                    }
                    else
                    {
                        Console.Write(dancingStr[i].ToString().ToLower());
                    }
                    isToUpper = !isToUpper;
                }
                else
                {
                    Console.Write(" ");

                }

            }
        }
    }
}
