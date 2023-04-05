using OOP.OopMedium;
using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace OOP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //12. Declare classes and print object ( class should contain method and properties)

            var person1 = new Person();
            person1.Id = 1;
            person1.Name = "Test";
            person1.BirthYear = 1900;
            var age = person1.Age(2023);
            Console.WriteLine($"Person Name: {person1.Name} \nId: {person1.Id} \nAge: {age}");



            //13.Declare structure and print object(use method and properties)

            Structure.Display();



            //14.Show that classes are reference type but primitive variable aren't

            var object1 = new ClassRefPrim();
            ClassRefPrim object2 = object1;

            Console.WriteLine($"value of object1: {object1.name}");
            Console.WriteLine($"value of object2: {object2.name}");
            
            object2.name = "Test"; //change the value of object2
            Console.WriteLine($"New value of object1: {object1.name}");
            Console.WriteLine($"New value of object2: {object2.name}");

            int intVar1 = 10;
            int intVar2 = intVar1;
            intVar2 = 20;
            Console.WriteLine($"Value of intVar1: {intVar1}");
            Console.WriteLine($"Value of intVar2: {intVar2}");



            //15. Declare arrays of size 15.Array type should be bool,char,int,long,double,string etc
            //16. Insert dummy value to those arrays and print them. While printing skip index no 5 and print until index 10. (use for,while,foreach,break,continue)

            ArrayDeclare.ArrayDisplay();



            //17.Declare Enum.Convert a string to enum, int to enum, enum to string, enum to int

            EnumConvertion.EnumDisplay();



            //18.Declare a 2 class containing the same method.One method should be static. Now access the method from main class

            StaticClass.Display();
            var nonStatic = new NonStatic();
            nonStatic.Display();



            //19.Declare a list of int,string,double.Find out all list manipulation methods and implement them.

            var list = new ListManipulation();
            list.Manipulation();


            //20. Declare an array of int,string,double.Find out all array manipulation methods and implement them.

            ArrayMethods.ArrayMethodOperation();



            //21. Declare datetime, timespan. Find all datetime manipulation methods.

            DatetimeEx.DatetimeExample();



            //22. Declare string and find all types of string manipulation methods.


            //23. Declare a string and change some character of the string(use StringBuilder)
            //24. Find out all StringBuilder methods

            StringBuilderEx.StringBuilderOperation();


            //1.Declare a class and with different type of access modifier(propertise+method)
            var accessMod = new AccessModifiers();
            accessMod.Print();


            //2. Declare a class with different type of constructor

            var constructor = new DifferentConstructor(12);
            Console.WriteLine(constructor.id);


            //3. Show different type of class inheritance

            ClassInheritance.PrintClassInh();


            //4. Show constructor inheritance

            var constrInh = new Derived(12, "C#");
            Console.WriteLine(constrInh.id + " " + constrInh.name);


            //5. Class upcasting and downcasting

            UpcastingDowncasting.Print();


            //6. Method overloading
            //7. Method overriding

            MethodOverloadingOverriding.PrintM();

            //8. Use interface
            //9. Use abstract class




        }
}
}
