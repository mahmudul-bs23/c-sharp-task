using System;

namespace OOP
{
    internal class StaticClass
    {
        public static void Display()
        {
            Console.WriteLine("This method is a static");
        }
    }

    public class NonStatic
    {
        public void Display()
        {
            Console.WriteLine("This method is non-static");
        }
    }
}
