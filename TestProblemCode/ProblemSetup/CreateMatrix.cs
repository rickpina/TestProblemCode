using System;
using System.Collections.Generic;
using System.Text;

namespace TestProblemCode.ProblemSetup
{
    class CreateMatrix
    {
        public static int[,] RandomMatrix(int NRows, int MColumns)
        {

            Random rnd = new Random();

            int[,] matrix = new int[NRows, MColumns];

            for (int i = 0; i < NRows; i++)
            {
                for (int k = 0; k < MColumns; k++)
                {
                    matrix[i, k] = rnd.Next(11);
                    Console.WriteLine($"Position ( {i}, {k} ) = {matrix[i, k]}.");
                }
            }
            return (matrix);
        }
    }
}
