/*
04. Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them. 
*/

using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        Console.Write("Enter first date in format dd.MM.yyyy: ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter second date in format dd.MM.yyyy: ");
        DateTime secondtDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("The difference between this two dates in {0} day(s)", (secondtDate - firstDate).TotalDays);
    }
}