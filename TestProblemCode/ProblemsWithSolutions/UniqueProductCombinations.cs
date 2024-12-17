using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProblemCode.ProblemsWithSolutions
{
    // Problem: Unique Product Combinations

    // You are given a list of products and their prices. Your task is to find all unique combinations of products that total up to a given target price.

    // Each product can be selected only once. Return a list of combinations, where each combination is represented as a list of product names.

    // Input:

    // Dictionary<string, int> products: A dictionary where keys are product names and values are their prices.
    // int targetPrice: The target total price for combinations.
    // Output:

    // A list of lists, where each inner list contains product names that add up to targetPrice.
    // Constraints:

    // Assume all prices are positive integers.
    // If no combination is possible, return an empty list.
    // The order of combinations in the result does not matter.

    public class UniqueProductCombinations
    {
        public static void FindUniqueProducts()
        {

            var products = new Dictionary<string, int>
            {
                {"Apple", 2},
                {"Banana", 3},
                {"Cherry", 4},
                {"Date", 5}
            };

            int targetPrice = 7;



            var productlist = products.ToList();

            List<List<string>> happyface = new List<List<string>>();


            for (int x = 0; x < productlist.Count; x++)
            {

                var productx = productlist[x];

                for (int y = 0; y < productlist.Count; y++)
                {

                    var producty = productlist[y];


                    if (productx.Value + producty.Value == targetPrice && productx.Key != producty.Key)
                    {

                        var combination = new List<string> { productx.Key, producty.Key };
                        combination.Sort();


                        if (!happyface.Any(h => h.SequenceEqual(combination)))
                        {
                            happyface.Add(combination);
                        }
                    }
                }
            }

            if (!happyface.Any())
            {
                Console.WriteLine("No items add to the target.");
            }
            else
            {
                foreach (var thing in happyface)
                {
                    foreach (var lol in thing)
                    {
                        Console.WriteLine(lol);
                    }
                }
            }
           

            
        }


       
    }
}
