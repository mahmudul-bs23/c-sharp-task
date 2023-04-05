using System;

namespace OOP
{
    internal class Structure
    {
        struct Books
        {
            public string title;
            public string author;

            public void SetValues(string t, string a)
            {
                title = t;
                author = a;
            }
            public void GetValues()
            {
                Console.WriteLine($"Title: {title}");
                Console.WriteLine($"Author: {author}");
            }
        }

        public static void Display()
        {
            Books book1 = new Books();
            book1.SetValues("Harry Potter", "JK. Rowling");
            book1.GetValues();
        }
    }
}
