/*
01. Define a method Fib(n) that calculates the nth Fibonacci number.
*/

using System;

    class FibonacciNumbers
    {
        static void Main()
        {
            int fiboNumber = 6;
			
			//print result
            Console.WriteLine(Fib(fiboNumber));
        }
        static uint Fib(int limit)
        {
            uint[] fibo = { 0, 1, 1 };
			//first element = 0
			//second element = 1
			//third element = 1

            uint result = 0;

            for (int i = 0; i <= limit; i++)
            {
                if (i > 2)
                {
                    fibo[0] = fibo[1];
                    fibo[1] = fibo[2];
                    fibo[2] = fibo[0] + fibo[1];
                    result = fibo[2];
                }
                else
                {
                    result = fibo[i];
                }
            }

            return result;
        }
    }