using System;
using System.Collections.Generic;
using System.Text;

namespace TestProblemCode.ProblemsWithSolutions
{
    class ReturnRandomSolution
    {
        public static void ReturnRandomDCP72()
        {
            //Using a function rand7() that returns an integer from 1 to 7(inclusive) with uniform probability,
            //implement a function rand5() that returns an integer from 1 to 5(inclusive).
            var rand = new Random();
            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,8:N0}", rand.Next(6));
            Console.WriteLine();
        }
    }
}
