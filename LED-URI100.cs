/*
LINK - >https://www.urionlinejudge.com.br/judge/en/problems/view/1168
John wants to set up a panel containing different numbers of LEDs. He does not have many leds, he is not sure if he will be able to mount the desired number.
Considering the configuration of the LEDs of the numbers below, make an algorithm that helps John to discover the number of LEDs needed to set the value.
Input
The input contains an integer N, (1 ≤ N ≤ 2000) corresponding to the number of test cases, followed by N lines, each line containing a number 

ATTENTION (1 ≤ V ≤ 10^100) -> (The program is working if the inputed number was between int range >= 1 and <= 2,147,483,647, PLEASE if you know to solve like the challenge asked
, contact me :] )

corresponding to the value that John wants to set with the leds.
Output
For each test case, print one line containing the number of LEDs that John needs to set the desired value, followed by the word "leds".
*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int index = int.Parse(Console.ReadLine());
            if (index >= 1 && index <= 2000)
            {
                for (int i = 0; i < index; i++)
                {

                    int actualNumber = int.Parse(Console.ReadLine());
                    if (actualNumber >= 1 && actualNumber <= Math.Pow(10,100))
                    {
                        string actualNumberStr = actualNumber.ToString();
                        int total = 0;

                        for (int j = 0; j < actualNumberStr.Length; j++)
                        {
                            if (actualNumberStr[j] == '2' || actualNumberStr[j] == '3' || actualNumberStr[j] == '5')
                            {
                                total += 5;
                            }
                            else if (actualNumberStr[j] == '9' || actualNumberStr[j] == '6' || actualNumberStr[j] == '0')
                            {
                                total += 6;
                            }
                            else if (actualNumberStr[j] == '1')
                            {
                                total += 2;
                            }
                            else if (actualNumberStr[j] == '4')
                            {
                                total += 4;
                            }
                            else if (actualNumberStr[j] == '7')
                            {
                                total += 3;
                            }
                            else
                            {
                                total += 7;
                            }

                        }
                        Console.WriteLine(total + " leds");
                    }
          
                }
            }
        }
    }
}
