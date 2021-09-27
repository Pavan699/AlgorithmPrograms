using System;

namespace AlgoritmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Algorithmic Programs");
            Console.WriteLine("1.BinarySearch\n2.InsertionSort\n3.BubbleSort\n4.PrimeNumbers\n5.Anagram\n6.CustomizeMessage\n7.Exit");
            Console.Write("Enter the Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (choice)
            {
                case 1:
                    BinarySearch.Search();
                    break;
                case 2:
                    InsertionSort.Insert();
                    break;
                case 3:
                    BubbleSort.Bubble();
                    break;
                case 4:
                    PrimeNumbers.Prime();
                    break;
                case 5:
                    Anagram ana = new Anagram();
                    String str1 = "abcd";
                    int num = str1.Length;
                    ana.anagram(str1, 0, num - 1);
                    break;
                case 6:
                    RegexInput regexp = new RegexInput();
                    regexp.Check();
                    break;
                default:
                    Console.WriteLine("Thank You... :)");
                    break;
            }
        }
    }
}
