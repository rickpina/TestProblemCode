using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


//Problem:
//The Fibonacci sequence is a series of numbers where:

//The first two numbers are 0 and 1.
//Each subsequent number is the sum of the two preceding numbers.
//Write a recursive method to calculate the Nth Fibonacci number.

//Input:

//Integer n(where n is a non-negative integer)
//Output:

//The Nth Fibonacci number
//Examples:

//If n = 0, the Fibonacci number is 0.
//If n = 1, the Fibonacci number is 1.
//If n = 5, the Fibonacci sequence up to n is: 0, 1, 1, 2, 3, 5 → Output: 5.
//If n = 7, the Fibonacci sequence up to n is: 0, 1, 1, 2, 3, 5, 8, 13 → Output: 13.

namespace TestProblemCode.ProblemsWithSolutions
{
    public class RecursiveFibonacci
    {
        public static void Display()
        {

            Solve(5, 0, 1);

        }


        private static void Solve(int nthFib, int currentFib, int nextFib)
        {

            if (nthFib > 0) {     
                
                nthFib--;
                Solve(nthFib, nextFib, currentFib += nextFib);

            }
            else
            {
                Console.WriteLine(currentFib);
            }

        }
    }
}
