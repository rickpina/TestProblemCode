using System;
using System.Collections.Generic;
using System.Text;

namespace TestProblemCode.ProblemsWithSolutions
{
    class ReverseStringSolution
    {
        public static void ReverseStringWithoutInbuiltMethod(string stringInput)
        {
            // Reverse using While loop  
            string reversestring = "";
            int length;

            length = stringInput.Length - 1;

            while (length >= 0)
            {
                reversestring = reversestring + stringInput[length];
                length--;
            }
            Console.WriteLine(reversestring);
        }
    }
}
