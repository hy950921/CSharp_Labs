using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Solution
    {
        int[] arr;

        public int Solutions(int[] arr)
        {
            Array.Sort(arr);
            int count = 1, res = arr[0], cur = 1;
            int length = arr.Length;
            for (int i = 1; i < length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    cur++;
                }
                else
                {
                    if (cur > count)
                    {
                        count = cur;
                        res = arr[i - 1];
                    }
                    cur = 1;
                }
            }
            if (cur > count)
            {
                res = arr[length - 1];
            }
            return res;
        }

        public void CreateArray()
        {
            Console.Write("Enter array size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            arr = new int[size];
        }

        public int[] FillArray()
        {
            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter array values: ");
                int val = Convert.ToInt32(Console.ReadLine());
                arr[i] = val;
            }
            return arr;
        }

        public void Display()
        {
            Console.Write("The values in the array are: ");
            foreach(int val in arr)
            {
                Console.Write($"{val} ");
            }
        }
    }
}
