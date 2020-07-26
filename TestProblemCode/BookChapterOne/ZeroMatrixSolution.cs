using System;
using System.Collections.Generic;
using System.Text;
using TestProblemCode.ProblemSetup;

namespace TestProblemCode.ProblemsWithSolutions
{
    public class ListforZeroMatrix
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }
    }

    class ZeroMatrixSolution
    {
        public static void ZeroMatrix(int[,] matrix, int NRows, int MColumns)
        {
            //Book Question : My Own Solution Pretty Sure it is O(N) Time and O(N) Space but not sure pretty messy but it is pretty fast.

            List<ListforZeroMatrix> MatrixPairValue = new List<ListforZeroMatrix>();
            int counter = 0;

            //Itterate through to find pairs with zero.
            for (int i = 0; i < NRows; i++)
            {
                for (int j = 0; j < MColumns; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        MatrixPairValue.Add(new ListforZeroMatrix() { Value1 = i, Value2 = j });
                        counter++;
                    }
                }
            }

            //Optimization would be to know what rows and columns have already been set to zero. This eliminates unnessasary repetitons.
            //Would have to add another List to hold those values then do a check to see if the current iteration matches any of the older ones.

            //Ended up adding two dictionaries because it had .ContainsKey probably a better way of doing this, OH WELL.
            Dictionary<int, int> xseenbefore = new Dictionary<int, int>();
            Dictionary<int, int> yseenbefore = new Dictionary<int, int>();

            foreach (ListforZeroMatrix item in MatrixPairValue)
            {
                Console.WriteLine($" Zero Found at: ( {item.Value1} , {item.Value2} ).");

                //ROW CHECKER
                for (int i = 0; i < NRows; i++)
                {
                    if (xseenbefore.TryGetValue(item.Value1, out int valuei))
                    {
                        if (xseenbefore.ContainsKey(item.Value1))
                        {
                            Console.WriteLine("X Contains Key");
                            break;
                        }
                    }
                    else
                        matrix[item.Value1, i] = 0;
                }

                if (xseenbefore.ContainsKey(item.Value1) == false)
                    xseenbefore.Add(item.Value1, item.Value2);

                //COlUMN CHECKER
                for (int j = 0; j < MColumns; j++)
                {
                    if (yseenbefore.TryGetValue(item.Value2, out int valuej))
                    {
                        if (yseenbefore.ContainsKey(item.Value2))
                        {
                            Console.WriteLine("Y Contains Key");
                            break;
                        }
                    }
                    else
                        matrix[j, item.Value2] = 0;
                }

                if (yseenbefore.ContainsKey(item.Value2) == false)
                    yseenbefore.Add(item.Value2, item.Value1);

            }
            Console.WriteLine("This is how many Zeros were found: " + counter);
        }
    }
}
