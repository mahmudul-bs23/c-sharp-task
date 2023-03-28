using System;

namespace operatorUse
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 25, num2 = 4;
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / (float)num2);
            Console.WriteLine(num1 % num2);
            Console.WriteLine(num1 | num2);
            Console.WriteLine(num1 ^ num2);
            Console.WriteLine(num1 & num2);
        }
    }
}