using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProblemCode.ProblemsWithSolutions
{
    class RemoveColumnsSolution
    {
        public static void RemoveColumnsDCP76()
        {
            /*[Medium]
                This problem was asked by Google.

                You are given an N by M 2D matrix of lowercase letters.
                Determine the minimum number of columns that can be removed to ensure that each row is ordered from top to bottom lexicographically.
                That is, the letter at each column is lexicographically later as you go down each row.
                It does not matter whether each row itself is ordered lexicographically.

                For example, given the following table:

                cba
                daf
                ghi
                This is not ordered because of the a in the center. We can remove the second column to make it ordered:

                ca
                df
                gi
                So your function should return 1, since we only needed to remove 1 column.

                As another example, given the following table:

                abcdef
                Your function should return 0, since the rows are already ordered(there's only one row).

                As another example, given the following table:

                zyx
                wvu
                tsr
                Your function should return 3, since we would need to remove all the columns to order it.
            */

            //Making the Matrix Array N x M             
            int rows = 3;
            int columns = 3;

            string[,] LowerLetters = new string[rows, columns];
            LowerLetters[0, 0] = "z";
            LowerLetters[0, 1] = "y";
            LowerLetters[0, 2] = "x";
            LowerLetters[1, 0] = "w";
            LowerLetters[1, 1] = "v";
            LowerLetters[1, 2] = "u";
            LowerLetters[2, 0] = "t";
            LowerLetters[2, 1] = "s";
            LowerLetters[2, 2] = "r";

            //Sets a number to each letter string so I can compare them.
            var alphabet = new Dictionary<int, string>
            {
                { 1, "a" },
                { 2, "b" },
                { 3, "c" },
                { 4, "d" },
                { 5, "e" },
                { 6, "f" },
                { 7, "g" },
                { 8, "h" },
                { 9, "i" },
                { 10, "j" },
                { 11, "k" },
                { 12, "l" },
                { 13, "m" },
                { 14, "n" },
                { 15, "o" },
                { 16, "p" },
                { 17, "q" },
                { 18, "r" },
                { 19, "s" },
                { 20, "t" },
                { 21, "u" },
                { 22, "v" },
                { 23, "w" },
                { 24, "x" },
                { 25, "y" },
                { 26, "z" }
            };

            //Solving the problem time

            //
            int temp = 99;
            int deletablerows = 0;
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    int myKey = alphabet.FirstOrDefault(x => x.Value == LowerLetters[c, r]).Key;

                    var what = alphabet.FirstOrDefault(x => x.Value == LowerLetters[c, r]);
                    Console.WriteLine(what);

                    if (temp > myKey && temp != 99)
                    {
                        deletablerows++;
                        temp = 99;
                        Console.WriteLine("Column: " + (r + 1) + " Needs to be deleted");
                        break;
                    }

                    temp = myKey;
                }
            }
            Console.WriteLine("This is how many rows should be deleted: " + deletablerows);
            Console.WriteLine("This was a O(n^2) solution.");
        }
    }
}
