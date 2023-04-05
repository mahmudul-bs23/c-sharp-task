using System;
using System.Linq;

namespace OOP
{
    internal class ArrayMethods
    {
        public static void ArrayMethodOperation()
        {
            int[] intArray = new int[] { 1, 2, 3, 8, 9, 10, 11, 12, 13, 14, 15, 4, 5, 6, 7, 20 };
            int[] copyArray = new int[20];
            string[] stringArray = new string[] {"hello", "world", "c#", "dot net"};

            int index = Array.IndexOf(intArray, 10);
            Console.WriteLine(index);

            Array.Copy(intArray, copyArray, intArray.Length);
            PrintArray(copyArray);


            Array.Sort(intArray);
            PrintArray(intArray);

            Array.Reverse(intArray);
            PrintArray(intArray);
        }


        static void PrintArray(int[] array)
        {

            Console.WriteLine();
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}
