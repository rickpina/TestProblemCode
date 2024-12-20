using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProblemCode.ProblemsWithSolutions
{
    /// <summary>
    /// Implement division of two positive integers without using the division, multiplication, or modulus operators.
    /// Return the quotient as an integer, ignoring the remainder.
    /// </summary>
    public class RestrictedDivision
    {
        public static void Display()
        {

            Solve(10, 2);

        }

        private static void Solve(int dividend, int divisor)
        {
            int quotient = 0;

            while (dividend > 0)
            {
                dividend -= divisor;

                if (dividend >= 0) { quotient++; }             
            }

            Console.WriteLine(quotient);
        }
    }
}
