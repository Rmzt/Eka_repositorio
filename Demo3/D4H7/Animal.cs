using System;

namespace D4H7
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Size { get; set; }

        public Animal() { }

        public Animal(string name, int size)
        {
            Name = name;
            Size = size;
        }
    }
}
