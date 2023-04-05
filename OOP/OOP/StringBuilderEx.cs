using System;
using System.Text;

namespace OOP
{
    internal class StringBuilderEx
    {
        public static void StringBuilderOperation()
        {
            var builder = new StringBuilder();
            builder.Append("This is a random string wowowowo");
            Console.WriteLine($"Before replace: {builder}");

            builder.Replace('w', 't');

            Console.WriteLine($"After replace: {builder}");

            builder.Remove(20, 7);
            Console.WriteLine(builder);
        }
    }
}
