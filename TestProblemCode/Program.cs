using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using TestProblemCode.ProblemsWithSolutions;
using TestProblemCode.ProblemSetup;
using TestProblemCode.BookChapterOne;

namespace QuickDate
{
    class Unfinished
    {
        private static void DCP75()
        {
            //Hard
            //This problem was asked by Microsoft.

            //Given an array of numbers, find the length of the longest increasing subsequence in the array. The subsequence does not necessarily have to be contiguous.

            //For example, given the array[0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15], the longest increasing subsequence has length 6: it is 0, 2, 6, 9, 11, 15.
        }
        private static void DCP80()
        {
            //Good morning!Here's your coding interview problem for today.
            //This problem was asked by Google.
            //Given the root of a binary tree, return a deepest node. For example, in the following tree, return d.
            //    a
            //   / \
            //  b c
            // /
            //d
        }
        private static void DataStructures()
        {
            Dictionary<string, string> openWith = new Dictionary<string, string>();

            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");


            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }

            Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);
        }
    }

    class TestProblems
    {            

        static void Main(string[] args)
        {

            //ZeroMatrixSolution.ZeroMatrix(CreateMatrix.RandomMatrix(10,10), 10, 10);
            //Console.WriteLine(StringCompression("wwooww"));
            //Console.Read();
            
            
        }

    }
}