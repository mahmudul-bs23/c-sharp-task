using System;

namespace typeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string strNumber = "123";
            string doubleStrNumber = "123.23";
            string longStrNumber = "9223372036854775807";
            string strBool = "true";
            int intNumber = 123;
            long longIntNumber = 9223372036854775807;
            double dNumber = 123.12d;
            float fNumber = 12.19f;
            bool boolValue = true;
            long longNumber = 12121212;
            char ch = 'a';
            int chInt = 97;

            Console.WriteLine("convert string to int vice-versa");
            Console.WriteLine(Convert.ToInt32(strNumber));
            Console.WriteLine(Convert.ToString(intNumber));

            Console.WriteLine("convert string to long vice-versa");
            Console.WriteLine(Convert.ToInt64(longStrNumber));
            Console.WriteLine(Convert.ToString(longIntNumber));

            Console.WriteLine("convert string to double vice-versa");
            Console.WriteLine(Convert.ToDouble(doubleStrNumber));
            Console.WriteLine(Convert.ToString(dNumber));

            Console.WriteLine("convert string to float vice-versa");
            Console.WriteLine((float)Convert.ToDouble(doubleStrNumber));
            Console.WriteLine(Convert.ToString(dNumber));

            Console.WriteLine("convert string to bool vice-versa");
            Console.WriteLine(Convert.ToBoolean(strBool));
            Console.WriteLine(Convert.ToString(boolValue));

            Console.WriteLine("convert int to long vice-versa");
            Console.WriteLine((long)intNumber);
            Console.WriteLine(Convert.ToInt64(longNumber));

            Console.WriteLine("character to ASCII int vice-versa");
            Console.WriteLine((int)ch);
            Console.WriteLine((char)chInt);
        }
    }
}