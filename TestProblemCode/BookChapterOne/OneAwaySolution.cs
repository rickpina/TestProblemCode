using System;
using System.Collections.Generic;
using System.Text;

namespace TestProblemCode.BookChapterOne
{
    class OneAwaySolution
    {
        public static bool OneAway(String str1, String str2)
        {
            if (str1.Length == str2.Length)
            {
                bool foundDif = false;
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        if (foundDif)
                        {
                            return false;
                        }
                        foundDif = true;
                    }
                }
                return true;
            }

            if (str1.Length - str2.Length == 1 || str1.Length - str2.Length == -1)
            {
                int iOne = 0;
                int iTwo = 0;

                while (iTwo < str2.Length && iOne < str1.Length)
                {
                    if (str1[iOne] != str2[iTwo])
                    {
                        if (iOne != iTwo)
                        {
                            return false;
                        }
                        iOne++;
                    }
                    else
                    {
                        iOne++;
                        iTwo++;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
