/*
Rolien and Naej are the developers of a big programming portal. To help the new site registration system, they requested your help.
Your job is write a code that validates passwords that are registered on the portal, for that you should be aware for the following requirements:

The password must contain at least one uppercase letter, one lowercase letter and a number;
It can’t have any punctuation character, accent or space;
Moreover, the password must be 6 to 32 characters.

https://www.beecrowd.com.br/judge/en/problems/view/2253
*/

using System;

namespace CompletePhrase
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            do
            {
                str = Console.ReadLine();
                
                if (isValidStr(str))
                {
                    Console.WriteLine("Senha valida.");

                    }
                else
                    {
                        Console.WriteLine("Senha invalida.");
                }
            } while (str != "EOF") ;
         
        }
        public static bool isValidStr(String str)
        {
            bool upperCaseLetter = false;
            bool lowerCaseLetter = false;
            bool isNumeric = false;
            bool punctuationSpaceOrAccent = false;
            if (str.Length < 6 || str.Length > 32)
            {
                return false;
            }
            for (int j = 0; j < str.Length; j++)
            {
                if (Char.IsUpper(str[j]))
                {
                    upperCaseLetter = true;
                }
                if (Char.IsLower(str[j]))
                {
                    lowerCaseLetter = true;
                }
                if (Char.IsNumber(str[j]))
                {
                    isNumeric = true;
                }

                if (!(str.Contains("@") || str.Contains("#")
                    || str.Contains("!") || str.Contains("~")
                    || str.Contains("$") || str.Contains("%")
                    || str.Contains("^") || str.Contains("&")
                    || str.Contains("*") || str.Contains("(")
                    || str.Contains(")") || str.Contains("-")
                    || str.Contains("+") || str.Contains("/")
                    || str.Contains(":") || str.Contains(".")
                    || str.Contains(", ") || str.Contains("<")
                    || str.Contains(">") || str.Contains("?")
                    || str.Contains("|") || str.Contains(" ")))
                {
                    punctuationSpaceOrAccent = true;
                }
            }
            return upperCaseLetter && lowerCaseLetter && isNumeric && punctuationSpaceOrAccent;
        }
    }
}
