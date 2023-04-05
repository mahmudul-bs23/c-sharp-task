using System;
using System.ComponentModel.DataAnnotations;

namespace OOP.OopMedium
{
    public class MethodOverload
    {
        public void Display(int a)
        {
            Console.WriteLine("Arguments: " + a);
        }

        // method with two parameters
        public void Display(int a, int b)
        {
            Console.WriteLine("Arguments: " + a + " and " + b);
        }
    }

    public class ParentClass
    {
        public virtual void Show()
        {
            Console.WriteLine("hello from Base Class A");
        }

    }

    public class SubClass : ParentClass
    {
        public override void Show()
        {
            Console.WriteLine("hello Derived class B");
        }
    }
    internal class MethodOverloadingOverriding
    {
        public static void PrintM()
        {
            //method overloading
            var methodOverload = new MethodOverload();
            methodOverload.Display(10);
            methodOverload.Display(20, 30);

            //method overriding
            ParentClass obj = new ParentClass();
            obj.Show();

            obj = new SubClass();
            obj.Show();
            Console.WriteLine(obj);
        }
    }
}
