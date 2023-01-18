using System;
using System.Diagnostics.CodeAnalysis;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 49762;
            int sumofDigits = 0;

             while (number > 0)
            {

               int lastDigits = number % 10;
               sumofDigits += lastDigits;
               number /= 10;

            }

            Console.WriteLine(sumofDigits);












        }
    }
}
