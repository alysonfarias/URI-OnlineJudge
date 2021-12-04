/*
Given three values, find out if they form a triangle. If so, check if the triangle is scalene, isoceles or equilateral and if it is a triangle rectangle or not.
*/


using System;

namespace WhichTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type 3 numbers");
            string[] TriangleSides = Console.ReadLine().Split(" ");
            int a, b, c;
            a = int.Parse(TriangleSides[0]);
            b = int.Parse(TriangleSides[1]);
            c = int.Parse(TriangleSides[2]);

            if (a + b > c && a + c > b && b + c > a) // checking if is a triangle
            {
                if (a == b && a == c) { 
                    Console.WriteLine("Valido-Equilatero\n Retangulo: N");
                }
                else
                {
                    if (a == b || a == c || b == c)
                    {
                        Console.WriteLine("Valido-Isosceles\nRetangulo: N");
                    } else
                    {
                        Console.WriteLine("Valido-Escaleno\nRetangulo: S");
                    
                    }
                }

            }
            else
            {
                Console.WriteLine("Inválido");
            }
        }
    }
}
