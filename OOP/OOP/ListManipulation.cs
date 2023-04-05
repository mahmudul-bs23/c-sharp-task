using System;

namespace OOP
{
    internal class ListManipulation
    {
        List<int> intList = new();

        public void Manipulation()
        {
            intList.Add(0);
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);

            intList.Sort();
            intList.Reverse();

            foreach (int i in intList)
            {
                Console.Write(i + " ");
            }

            intList.Remove(0);

            Console.WriteLine();
            foreach (int i in intList)
            {
                Console.Write(i + " ");
            }
        }
    }
}
