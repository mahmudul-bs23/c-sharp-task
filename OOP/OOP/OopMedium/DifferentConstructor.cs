using System;


namespace OOP.OopMedium
{
    internal class DifferentConstructor
    {
        public string ?name;
        public int age;
        public int id;
        public DifferentConstructor()
        {
            
        }

        public DifferentConstructor(int id)
        {
            this.id = id;
        }
        public DifferentConstructor(string name, int age, int id)
            :this(id)
        {
            this.name = name;
            this.age = age;
        }
    }
}
