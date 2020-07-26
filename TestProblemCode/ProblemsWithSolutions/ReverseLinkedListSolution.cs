using System;
using System.Collections.Generic;
using System.Text;

namespace TestProblemCode.ProblemsWithSolutions
{
    class ReverseLinkedListSolution
    {
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

        public static void DCP73ReverseLinkedList()
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
    }
}
