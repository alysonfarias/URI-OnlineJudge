/*
Given a sorted array of distinct integers and a target value, return the index if the target is found. 
If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.
*/
using System;

namespace SearchInsertPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 4, 7, 8, 9 , 18};
            int target = 12;
            Console.WriteLine(searchInsert(array, target));
            
        }
        static int searchInsert(int[] array, int target)
        {
            int qtd = array.Length;
            for (int i = 0; i < qtd; i++)
            {
                if(array[i] >= target)
                {
                    return i;
                }
            }
            return qtd;
        }

    }


}

