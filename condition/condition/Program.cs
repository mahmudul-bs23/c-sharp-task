using System;

namespace condition
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 9;

            if(age > 18)
            {
                Console.WriteLine("You are eligible to vote");
            } 
            else if(age > 10)
            {
                Console.WriteLine("You are eligible to visit here");
            }
            else
            {
                Console.WriteLine("Go to sleep kid");
            }

            string name = "alex", country = "Bangladesh";

            if(name == "john" &&  country == "Australia")
            {
                Console.WriteLine("Real acc");
            }
            else if(name == "alex" && country == "Bangladesh")
            {
                Console.WriteLine("Fake acc");
            }
            else if(name == "karim" || country == "India")
            {
                Console.WriteLine("Not accepted");
            }

            Console.WriteLine("Use of ternery logical operator");
            Console.WriteLine(age > 18 ? "Vote" : "No vote");
        }
    }
}