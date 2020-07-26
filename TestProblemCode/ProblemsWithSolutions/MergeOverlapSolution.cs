using System;
using System.Collections.Generic;
using System.Text;

namespace TestProblemCode.ProblemsWithSolutions
{
    class MergeOverlapSolution
    {
        class ListforDCP77
        {
            public int ID { get; internal set; }
            public int ID2 { get; internal set; }
        }
        static readonly List<ListforDCP77> DCP77List = new List<ListforDCP77>
            {
                new ListforDCP77(){ ID = 1, ID2 = 3 },
                new ListforDCP77(){ ID = 5, ID2 = 8 },
                new ListforDCP77(){ ID = 2, ID2 = 100 },
                new ListforDCP77(){ ID = 4, ID2 = 10 },
                new ListforDCP77(){ ID = 20, ID2 = 25 }
            };

        public static void MergeOverlapDCP77()
        {
            //this problem was asked by Snapchat.

            //Given a list of possibly overlapping intervals, return a new list of intervals where all overlapping intervals have been merged.

            //The input list is not necessarily ordered in any way.

            //For example, given[(1, 3), (5, 8), (4, 10), (20, 25)], you should return [(1, 3), (4, 10), (20, 25)].



            //This is a solution I guess.
            var goomba = DCP77List;

            for (int i = 0; i < DCP77List.Count; i++)
            {
                //Console.WriteLine(goomba[i].ID);
                //Console.WriteLine(goomba[i].ID2);
                try
                {
                    if (goomba[i].ID >= goomba[i + 1].ID || goomba[i].ID2 >= goomba[i + 1].ID2)
                    {
                        goomba[i].ID = 0;
                        goomba[i].ID2 = 0;
                        i--;
                    }
                }
                catch
                {
                    continue;
                }


            }
            //&& goomba[i + 1].ID < DCP77List.Count
            for (int i = 0; i < DCP77List.Count; i++)
            {
                Console.WriteLine(goomba[i].ID);
                Console.WriteLine(goomba[i].ID2);
            }
        }
    }
}
