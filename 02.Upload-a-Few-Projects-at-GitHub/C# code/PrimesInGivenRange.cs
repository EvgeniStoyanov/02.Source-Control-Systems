/*
03. Write a method that calculates all prime numbers in given range and returns them as list of integers:
    …
Write a method to print a list of integers. Write a program that enters two integer numbers 
(each at a separate line) and prints all primes in their range, separated by a comma.
*/

using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main(string[] args)
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());
        //int startNum = 100;
        //int endNum = 200;

        PrintList(FindPrimesInRange(startNum, endNum));
    }

    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> listPrimes = new List<int>();

        for (int i = startNum; i <= endNum; i++)
        {
            if (IsPrime(i))
            {
                listPrimes.Add(i);
            }
        }

        return listPrimes;
    }

    static bool IsPrime(int number)
    {
        if (number > 1)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        return false;
    }

    static void PrintList(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i]);

            if (i < list.Count - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
    }

}