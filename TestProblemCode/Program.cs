using System;

namespace QuickDate
{
    internal class TestProblems
    {
        private static void FizzBuzz()
        {
            for (var i = 1; i < 101; i++)
            {
                if (i % 15 == 0) Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }
        }
        private static void ArraySum()
        {
            //dds the array contents
            int[] a = new int[] { 1, 2, 3 };
            int[] b = new int[] { 99, 16, 8 };
            int sum = 0;
            for (int count = 0; count < a.Length; count++)
            {
                sum += a[count];
            }

            Console.WriteLine(sum);
        }
        private static void DCP70()
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
        private static void DCP71()
        {
            //Using a function rand7() that returns an integer from 1 to 7(inclusive) with uniform probability,
            //implement a function rand5() that returns an integer from 1 to 5(inclusive).
            var rand = new Random();
            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,8:N0}", rand.Next(6));
            Console.WriteLine();
        }
        private static void DCP72()
        {
            //Given the head of a singly linked list, reverse it in-place.
        }

        static void Main(string[] args)
        {
            
            DCP71();
            
        }




    }
}