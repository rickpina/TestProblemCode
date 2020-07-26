using System;
using System.Collections.Generic;
using System.Text;

namespace TestProblemCode.BookChapterOne
{
    class URLifySolution
    {
        public static string URLify(String str, int strlength)
        {
            string newstring = str.TrimEnd();

            string easymethod = newstring.Replace(@" ", "%20");

            return easymethod;

            //    for(int i = 0; i < strlength; i++)
            //    {
            //        int val = newstring[i];

            //        if (val == 32)
            //        {
            //            string urlString = newstring.Replace(newstring[i], '%');
            //            return urlString;                    
            //        }
            //    }
            //    return newstring;
            //
        }
    }
}
