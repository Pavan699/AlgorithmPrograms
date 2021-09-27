using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmPrograms
{
    class BubbleSort
    {
        /// <summary>
        /// Bubble() method to sort the given integer array(list of numbers)
        /// </summary>
        public static void Bubble()
        {
            int[] number = { 50, 12, 87, 369, 1, 446, 99, 62 };
            bool flag = true;
            int temp;
            int numLength = number.Length;
            //sorting an array  
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (number[j + 1] < number[j])
                    {
                        //Swapping the numbers
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                        //for going next iteration making flag true
                        flag = true;
                    }
                }
            }
            //Print the Sorted array  
            foreach (int num in number)
            {
                Console.Write("  " + num);
            }
        }
    }
}
