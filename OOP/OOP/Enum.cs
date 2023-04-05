using System;

namespace OOP
{
    internal class EnumConvertion
    {
        enum Counts { one, two, three };
        public static void EnumDisplay()
        {
            // convert string to enum
            string countString = "one";
            Counts countEnum = (Counts)Enum.Parse(typeof(Counts), countString);
            Console.WriteLine($"Converted string to enum: {countEnum}");


            // convert int to enum
            int value = 1;
            Counts count = (Counts)Enum.Parse(typeof(Counts), value.ToString());
            Console.WriteLine($"Converted int to enum: {count}");


            // convert enum to string
            Console.WriteLine($"Converted enum to string: {Counts.one.ToString()}");

            // convert enum to int
            Console.WriteLine($"Converted enum to int: {(int)Counts.one}");
        }
    }
}
