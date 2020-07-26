using System;
using System.Collections.Generic;
using System.Text;

namespace TestProblemCode.ProblemsWithSolutions
{
    class MultiplicationTableSolution
    {
        public static void DCP74MultiplicationTable()
        {
            //This problem was asked by Apple.

            //Suppose you have a multiplication table that is N by N.That is,
            //a 2D array where the value at the i - th row and j - th column is (i + 1) * (j + 1)(if 0 - indexed) or i *j(if 1 - indexed).

            //Given integers N and X, write a function that returns the number of times X appears as a value in an N by N multiplication table.

            //For example, given N = 6 and X = 12, you should return 4, since the multiplication table looks like this:

            //| 1 | 2 | 3 | 4 | 5 | 6 |

            //| 2 | 4 | 6 | 8 | 10 | 12 |

            //| 3 | 6 | 9 | 12 | 15 | 18 |

            //| 4 | 8 | 12 | 16 | 20 | 24 |

            //| 5 | 10 | 15 | 20 | 25 | 30 |

            //| 6 | 12 | 18 | 24 | 30 | 36 |

            //And there are 4 12's in the table.


            //Creating the table using a Jagged Array
            const int N = 6;
            int targetX = 12;
            int multiples = 0;

            var namelist3 = new int[N][];
            for (int i = 0; i < N; i++)
            {
                namelist3[i] = new int[N];
                int j = 0;
                for (int k = 0; k < N; k++)
                {
                    namelist3[i][j] = (i + 1) * (j + 1);
                    //Console.WriteLine(namelist3[i][j]);
                    j++;
                }
            }

            // O(logn) Found this myself. Still more optimization possibilitis but I'm happy with this for now. 
            int q = N - 1;
            for (int i = 0; i < N; i++)
            {
                if (q <= -1)
                {
                    break;
                }
                if (namelist3[i][q] == targetX)
                {
                    Console.WriteLine("You Found a multiple of " + targetX);
                    Console.WriteLine(" The Multiple " + (i + 1) + " and " + (q + 1));
                    multiples++;
                }
                if (namelist3[i][q] < targetX)
                {
                    Console.WriteLine("Too Low! " + namelist3[i][q]);
                    Console.WriteLine(" The Multiple " + (i + 1) + " and " + (q + 1));

                }
                else if (namelist3[i][q] > targetX)
                {
                    Console.WriteLine("Too High! " + namelist3[i][q]);
                    Console.WriteLine(" The Multiple " + (i + 1) + " and " + (q + 1));
                    q--;
                    i--;
                }
            }
            Console.WriteLine("There are " + multiples + " multiples of " + targetX + " in this multiplication table of " + N + " by " + N);
        }
    }
}
