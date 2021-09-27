using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmPrograms
{
    class Anagram
    {
        /// <summary>
        /// anagram() method to check the entered string is anagram or not
        /// </summary>
        /// <param name="str">given string</param>
        /// <param name="l">staring index</param>
        /// <param name="r">ending index</param>
        public void anagram(String str, int l, int r)
        {
            if (l == r)
            {
                if (str == "dcba")
                {
                    Console.WriteLine("It is Anagram");
                }
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    anagram(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
        }
        /// <summary>
        /// Swap() method to swap the character in string
        /// </summary>
        /// <param name="a"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        static String swap(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
