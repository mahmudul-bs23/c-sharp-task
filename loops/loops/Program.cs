using System;

namespace differentLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For loop");
            for(int i = 1; i <= 100; i++)
            {
                if(i == 99)
                {
                    break;
                }
                else if(i == 95)
                {
                    continue;
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Using while loop");
            int j = 0;
            while(j <= 100)
            {
                j++;
                if (j == 99)
                {
                    break;
                }
                else if (j == 95)
                {
                    continue;
                }
                else
                {
                    Console.Write(j + " ");

                }
            }
            j = 0;
            Console.WriteLine();
            Console.WriteLine("Using do while loop");
            do {
                j++;
                if (j == 99)
                {
                    break;
                }
                else if (j == 95)
                {
                    continue;
                }
                else
                {
                    Console.Write(j + " ");

                }
            } while(j <= 100);

            Console.WriteLine();
            Console.WriteLine("Using forEach loop");
            foreach(int k in Enumerable.Range(1, 100))
            {
                if (k == 99)
                {
                    break;
                }
                else if (k == 95)
                {
                    continue;
                }
                else
                {
                    Console.Write(k + " ");
                }
            }
        }
    }
}