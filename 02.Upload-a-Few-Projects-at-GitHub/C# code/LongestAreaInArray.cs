/*
06. Write a program to find the longest area of equal elements in array of strings. 
You first should read an integer n and n strings (each at a separate line), then find and 
print the longest sequence of equal elements (first its length, then its elements). 
If multiple sequences have the same maximal length, print the leftmost of them. 
*/

using System;


class LongestAreaInArray
{
    static void Main(string[] args)
    {
        //string[] sequence = { "hi", "hi", "ho", "ho", "ho", "ho", "ha", "ha", "ha", "ha", };

        int number = int.Parse(Console.ReadLine());
        string[] sequence = new string[number];

        int position = 0;
        int maxArea = 0;
        int area = 1;


        for (int i = 1; i < sequence.Length; i++)
        {
            //
            sequence[i] = Console.ReadLine();

            if (sequence[i] == sequence[i - 1])
            {
                area++;

                if (area > maxArea)
                {
                    maxArea = area;
                    position = i;
                }
            }
            else
            {
                area = 1;
            }
        }

        Console.WriteLine(maxArea);

        for (int i = position - maxArea + 1; i <= position; i++)
        {
            Console.WriteLine(sequence[i]);
        }
    }
}