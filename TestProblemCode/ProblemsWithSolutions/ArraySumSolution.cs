using System;
using System.Collections.Generic;
using System.Text;

namespace TestProblemCode.ProblemsWithSolutions
{
    class ArraySumSolution
    {
        public static void ArraySum()
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
    }
}
