using System;


namespace OOP.OopMedium
{
    //single inheritance
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }

    //Hierarchical Inheritance
    //class Animal
    //{
    //    public void Eat()
    //    {
    //        Console.WriteLine("Eating...");
    //    }
    //}

    //class Dog : Animal
    //{
    //    public void Bark()
    //    {
    //        Console.WriteLine("Barking...");
    //    }
    //}

    //class Cat : Animal
    //{
    //    public void Meow()
    //    {
    //        Console.WriteLine("Meowing...");
    //    }
    //}


    //Multilevel inheritance
    //class Animal
    //{
    //    public void Eat()
    //    {
    //        Console.WriteLine("Eating...");
    //    }
    //}

    //class Dog : Animal
    //{
    //    public void Bark()
    //    {
    //        Console.WriteLine("Barking...");
    //    }
    //}

    //class Bulldog : Dog
    //{
    //    public void Snore()
    //    {
    //        Console.WriteLine("Snoring...");
    //    }
    //}

  


    internal class ClassInheritance
    {
        public static void PrintClassInh()
        {
            //single inheritance
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            //Hierarchical Inheritance
            //Dog dog = new Dog();
            //dog.Eat();
            //dog.Bark();

            //Cat cat = new Cat();
            //cat.Eat();
            //cat.Meow();


            //Multilevel inheritance
            //Bulldog bulldog = new Bulldog();
            //bulldog.Eat();
            //bulldog.Bark();
            //bulldog.Snore();



        }
    }
}
