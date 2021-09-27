using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmPrograms
{

    class InsertionSort
    {
        public static void Insert()
        {
            Console.Write("Enter the Sentence to Sort words :");
            string input = Console.ReadLine();
            string[] arr = input.Split(" ");
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                string key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j].CompareTo(key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            print(arr);
            void print(string[] arr)
            {
                int n = arr.Length;
                for (int i = 0; i < n; ++i)
                    Console.Write(arr[i] + " ");

                Console.Write("\n");
            }
        }
    }
}
