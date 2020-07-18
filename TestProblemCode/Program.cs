using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace QuickDate
{
    class TestProblems
    {
        private static void FizzBuzz()
        {
            for (var i = 1; i < 101; i++)
            {
                if (i % 15 == 0) Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }
        }
        private static void ArraySum()
        {
            //dds the array contents
            int[] a = new int[] { 1, 2, 3 };
            int[] b = new int[] { 99, 16, 8 };
            int sum = 0;
            for (int count = 0; count < a.Length; count++)
            {
                sum += a[count];
            }

            Console.WriteLine(sum);
        }
        private static void DCP71()
        {
            //Good morning!Here's your coding interview problem for today.

            //This problem was asked by Microsoft.

            //A number is considered perfect if its digits sum up to exactly 10.
            //Given a positive integer n, return the n - th perfect number.
            //For example, given 1, you should return 19.Given 2, you should return 28.

            //Easy

            int a = 111;
            int b;

            b = 10 - a;
            b = b + a;
            Console.WriteLine(b);
        }
        private static void DCP72()
        {
            //Using a function rand7() that returns an integer from 1 to 7(inclusive) with uniform probability,
            //implement a function rand5() that returns an integer from 1 to 5(inclusive).
            var rand = new Random();
            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,8:N0}", rand.Next(6));
            Console.WriteLine();
        }
        private static void DCP73ReverseLinkedList()
        {
            //Given the head of a singly linked list, reverse it in-place.
            string[] lol = { "1", "2", "3", "4", "5" };
            LinkedList<string> bunga = new LinkedList<string>(lol);
            Display(bunga, "Displaying the Linked List :)");

            var head = bunga.First;
            while (head.Next != null)
            {
                var next = head.Next;
                bunga.Remove(next);
                bunga.AddFirst(next.Value);
                Display(bunga, "Displaying the Linked List :)");
            }

            //My First way of solving this. Time = O(n) but also Space = O(n) as well making it worse.
            /*
            List<string> reverse = new List<string>();
            for (int i = 0; i < bunga.Count; i++)
            {
                reverse.Add(bunga.Last.Value);
                bunga.AddFirst(bunga.Last.Value);
                bunga.RemoveLast();

                Display(bunga, "Displaying the Linked List :)");
            }

            foreach (string pop in reverse)
            {
                Console.WriteLine(pop + " ");
            }
            */
        }
        private static void Display(LinkedList<string> words, string test)
        {
            Console.WriteLine(test);
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        private static void DCP74MultiplicationTable()
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
        private static void DCP75()
        {
            //Hard
            //This problem was asked by Microsoft.

            //Given an array of numbers, find the length of the longest increasing subsequence in the array. The subsequence does not necessarily have to be contiguous.

            //For example, given the array[0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15], the longest increasing subsequence has length 6: it is 0, 2, 6, 9, 11, 15.
        }
        private static void DCP76()
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
                        Console.WriteLine("Column: " + (r+1) +  " Needs to be deleted");
                        break;
                    }

                    temp = myKey;
                }
            }
            Console.WriteLine("This is how many rows should be deleted: " + deletablerows);
            Console.WriteLine("This was a O(n^2) solution.");
        }
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
        private static void DCP77()
        {
            //this problem was asked by Snapchat.

            //Given a list of possibly overlapping intervals, return a new list of intervals where all overlapping intervals have been merged.

            //The input list is not necessarily ordered in any way.

            //For example, given[(1, 3), (5, 8), (4, 10), (20, 25)], you should return [(1, 3), (4, 10), (20, 25)].



            //This is a solution I guess. Too lazy to make better :)
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
        private static void ReverseStringWithoutInbuiltMethod(string stringInput)
        {
            // Reverse using While loop  
            string reversestring = "";
            int length;

            length = stringInput.Length - 1;

            while (length >= 0)
            {
                reversestring = reversestring + stringInput[length];
                length--;
            }
            Console.WriteLine(reversestring);

            Console.ReadLine();

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
        private static bool IsUnique(String str)
        {
            Console.WriteLine("This solution is O(n) Time and O(1) Space");
            if (str.Length > 128)
            {
                Console.WriteLine("False");
                return false;
            }
            
            bool[] charset = new bool[128];
            for(int i = 0; i < str.Length; i++)
            {
                int val = str.ElementAt(i);
                if (charset[val])
                {
                    Console.WriteLine("False");
                    return false;
                }
                charset[val] = true;
            }
            Console.WriteLine("True");
            return true;
        }

        static void Main(string[] args)
        {

            //DCP73ReverseLinkedList();
            //DCP74MultiplicationTable();
            //DCP76();          
        }




    }
}