/*
02. Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. 
*/

using System;

class PrimeChecker
{
    static void Main(string[] args)
    {
        long number = 6737626471;
        Console.WriteLine("{0} is prime - {1}", number, IsPrime(number));

    }
    static bool IsPrime(long number)
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
}