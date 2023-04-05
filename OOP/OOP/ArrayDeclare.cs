using System;


namespace OOP
{
    internal class ArrayDeclare
    {

        public static void ArrayDisplay()
        {
            bool[] boolArray = new bool[15];
            char[] charArray = new char[15];
            int[] intArray = new int[15] { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15 };
            long[] longArray = new long[15];
            double[] doubleArray = new double[15];
            string[] stringArray = new string[15];

            int k = 0;
            foreach (int i in intArray)
            {
                if(k == 5)
                {
                    k++;
                    continue;
                }
                if(k == 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(i);
                }
                k++;
            }
        }
        
    }
}
