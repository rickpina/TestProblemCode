using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProblemCode.BookChapterOne
{
    class StringCompressionSolution
    {
        public static void StringCompression(String s1)
        {
            // This is a O(n) Time and Space Solution

            char temp = s1.ElementAt(0);
            int count = 0;
            List<string> cstring = new List<string>();

            for (int i = 0; i < s1.Length; i++)
            {
                if (temp == s1.ElementAt(i))
                {
                    count++;
                }
                else if (temp != s1.ElementAt(i))
                {
                    cstring.Add("" + temp + count);
                    temp = s1.ElementAt(i);
                    count = 1;
                }
            }

            cstring.Add("" + temp + count);

            string finalstring = string.Join("", cstring);
            Console.WriteLine(finalstring);
        }
    }
}
