using System;


namespace OOP.OopMedium
{
    internal class AccessModifiers
    {
        public int Id { get; set; }
        public string ?Name { get; set; }

        public void Print()
        {
            Console.WriteLine($"Object will be printed from here.. {Id} {Name}");
        }

        private void PrintName()
        {
            Console.WriteLine($"Name is {Name}");
        }

        protected string GetDateTime()
        {
            return DateTime.Now.ToString("\"yyyy, MMMM dd\"");
        }
    }

    internal class DerivedClass : AccessModifiers
    {
        
    }
}
