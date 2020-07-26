using System;
using System.Collections.Generic;
using System.Text;

namespace TestProblemCode.ProblemsWithSolutions
{
    class PerfectNumberSolution
    {
        public static void PerfectNumberDCP71()
        {
            //Good morning!Here's your coding interview problem for today.

            //This problem was asked by Microsoft.

            //A number is considered perfect if its digits sum up to exactly 10.
            //Given a positive integer n, return the n - th perfect number.
            //For example, given 1, you should return 19.Given 2, you should return 28.

            //Easy

            int a = 111;
            int b;

            b = 10 - a;
            b = b + a;
            Console.WriteLine(b);
        }
    }
}
