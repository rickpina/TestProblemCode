using System;
using System.Collections.Generic;
using System.Text;

namespace TestProblemCode.BookChapterOne
{
    class RotateMatrixSolution
    {
        public static void RotateMatrix()
        {
            const int N = 4;

            var matrix = new int[N][];
            for (int i = 0; i < N; i++)
            {
                matrix[i] = new int[N];
                int j = 0;
                for (int k = 0; k < N; k++)
                {
                    matrix[i][j] = (i + 1) * (j + 1);
                    j++;
                }
            }

            if (matrix.Length == 0 || matrix.Length != matrix[0].Length) { Console.WriteLine("What are you doing bruh"); }
            int n = matrix.Length;

            for (int layer = 0; layer < n / 2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;
                for (int i = first; i < last; i++)
                {
                    int offset = i - first;
                    int top = matrix[first][i]; //save top;

                    // left -> top
                    matrix[first][i] = matrix[last - offset][first];

                    // bottom -> left
                    matrix[last - offset][first] = matrix[last][last - offset];

                    // right -> bottom
                    matrix[last][last - offset] = matrix[i][last];

                    // top -> right
                    matrix[i][last] = top; //right <- saved top
                }
            }
            Console.WriteLine("Done");
        }
    }
}
