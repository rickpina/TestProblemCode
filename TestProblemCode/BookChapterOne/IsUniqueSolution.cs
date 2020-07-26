using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProblemCode.BookChapterOne
{
    class IsUniqueSolution
    {
        public static bool IsUnique(String str)
        {
            //This solution is O(n) Time and O(1) Space
            if (str.Length > 128)
            {
                Console.WriteLine("False");
                return false;
            }

            bool[] charset = new bool[128];
            for (int i = 0; i < str.Length; i++)
            {
                int val = str.ElementAt(i);
                if (charset[val])
                {
                    Console.WriteLine("False");
                    return false;
                }
                charset[val] = true;
            }
            Console.WriteLine("True");
            return true;
        }
    }
}
