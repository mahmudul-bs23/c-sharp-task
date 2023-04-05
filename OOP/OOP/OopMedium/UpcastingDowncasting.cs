using System;


namespace OOP.OopMedium
{
    class Person
    {
        public string ?Name { get; set; }
    }

    class Student : Person
    {
        public int Id { get; set; }
    }
    internal class UpcastingDowncasting
    {
        public static void Print()
        {
            var student = new Student()
            {
                Name = "World",
                Id = 1
            };

            Person person = student; // upcast
            Console.WriteLine(person.Name);
            //error
            //Console.WriteLine(person.Id);

            Student student2 = (Student)person; //downcast
            Console.WriteLine(student2.Name);
            Console.WriteLine(student2.Id);
        }
    }
}
