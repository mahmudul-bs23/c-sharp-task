using System;

namespace overflowException
{
    class Program
    {
        static void Main(string[] args)
        {
            double big_number = 1210394850923850923d;
            try
            {
                checked
                {
                    int x = (int)big_number;
                    Console.WriteLine("No overflow");
                }
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Overflow Exception caught as: " + ex.ToString());
            }
        }
    }
}