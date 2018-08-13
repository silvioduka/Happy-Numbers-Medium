﻿/*
Happy Numbers - Medium from Coding Challenges
by Silvio Duka

Last modified date: 2018-03-12

If the repeated sum of squares of the digits of a number is equal to 1, it is considered to be happy. 

For Example: 
23 is a happy number, as: 
2 ^ 2 + 3 ^ 2 = 13 
1 ^ 2 + 3 ^ 2 = 10 
1 ^ 2 + 0 ^ 2 = 1 

Sequence of happy numbers: 1, 7, 10, 13, 19, 23, ... 

Tasks: 
(Easy) Write a program to verify whether a given number is happy or not. 
(Medium) Write a program to find all the happy numbers in a range. 
(Hard) Given a number, write a program to verify whether it's happy or not and to display every sum of squares operation performed till the result is obtained. 

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1; // Insert a start number of range
            int finish = 1000; // Insert a end number of range

            Console.WriteLine($"The Happy Numbers in the range from {start} to {finish} are:");

            for (int number = start, i = 1; number <= finish; number++)
            {
                if (IsHappyNumber(number) == true) Console.Write($"{number}, {((i++ % 10 == 0)?"\n":"")}");
            }
        }

        static bool IsHappyNumber(int n)
        {
            int h = 0;

            while (true)
            {
                while (true)
                {
                    h += (int)Math.Pow(n % 10, 2);
                    n /= 10;
                    if (n == 0) break;
                }

                if (h == 1) return true;
                if (h == 4) return false;

                n = h;
                h = 0;
            }
        }
    }
}