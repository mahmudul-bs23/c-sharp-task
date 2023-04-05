using System;
using System.Security.AccessControl;

namespace OOP.OopMedium
{
    internal class ConstructorInheritance
    {
        public int id;
        public ConstructorInheritance(int id)
        {
            this.id = id;

        }
    }

    class Derived : ConstructorInheritance
    {
        public string name;
        public Derived(int id, string name)
            :base(id)
        {
            this.name = name;
        }
    }
}
