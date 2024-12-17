using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProblemCode.ProblemsWithSolutions
{
    //Problem: Generate All Subsets of a Set
    //Given a list of distinct integers, write a function to generate all possible subsets(the power set). The solution should use recursion.

    //Example
    //Input:
    //nums = [1, 2, 3]

    //Output:

    //less
    //Copy code
    //[   [],            // The empty subset
    //    [1],
    //    [2],
    //    [3],
    //    [1, 2],
    //    [1, 3],
    //    [2, 3],
    //    [1, 2, 3]
    //]
    //Requirements
    //Solve the problem using recursion.
    //No duplicate subsets should appear in the output.
    //Return a list of all subsets.

    public class SubsetsOfASet
    {
        // Single method for generating and printing subsets using recursion
        public static void GenerateSubsets(params int[] nums)
        {
            List<List<int>> result = new List<List<int>>();
            GenerateSubsetsRecursive(nums, 0, new List<int>(), result);  // Call recursive logic

            // Print all subsets directly within the class
            foreach (var subset in result)
            {
                Console.WriteLine("[" + string.Join(", ", subset) + "]");
            }
        }

        // Recursive logic embedded within the method
        private static void GenerateSubsetsRecursive(int[] nums, int index, List<int> current, List<List<int>> result)
        {
            if (index == nums.Length) // Base case: when we've processed all elements
            {
                result.Add(new List<int>(current)); // Add the current subset to the result
                return;
            }

            // Include the current element in the subset
            current.Add(nums[index]);
            GenerateSubsetsRecursive(nums, index + 1, current, result); // Recurse with element included

            // Exclude the current element from the subset
            current.RemoveAt(current.Count - 1);
            GenerateSubsetsRecursive(nums, index + 1, current, result); // Recurse with element excluded
        }
    }
}
