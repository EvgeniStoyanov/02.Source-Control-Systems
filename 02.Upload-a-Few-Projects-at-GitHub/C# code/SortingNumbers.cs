/*
05. Write a program that reads a number n and a sequence of n integers, sorts them and prints them. 
*/

using System;

class SortingNumbers
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());

        int[] sequence = new int[numbers];

        for (int a = 0; a < numbers; a++)
        {
            sequence[a] = int.Parse(Console.ReadLine());
        }

        Array.Sort(sequence);

        foreach (var item in sequence)
        {
            Console.WriteLine(item);
        }
    }
}