/*
 * C# Program to Check whether the Entered Number is Even or Odd
 */
using System;

namespace check1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a number: ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Number is even");
            }
            else
            {
                Console.Write("Number is odd");
            }
        }
    }
}
