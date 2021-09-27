using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmPrograms
{
    class BinarySearch
    {
        /// <summary>
        /// Search method to search the word is present or not in entered sentance
        /// </summary>
        public static void Search()
        {
            string input = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] Words = input.Split(" ");//Split the sentance by using Split function with Space           
            Array.Sort(Words);//Sorted the function
            Console.WriteLine("Sorted Array is : ");
            for(int j =0;j<Words.Length;j++)
            {
                Console.Write(Words[j] + " ");
            }
            Console.WriteLine();
            Console.Write("Enter the word to search : ");
            string word = Console.ReadLine();//input word to search
            int i = Array.BinarySearch(Words, word);//finding position of the word in sorted Array
            if (i >= 0)
            {
                Console.WriteLine("word {0} found at position {1}", word, i);
            }
            else
            {
                Console.WriteLine("word {0} is not found\n");
            }
        }
    }
}
