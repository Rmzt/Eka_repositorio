using System;

namespace D4H7
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Size { get; set; }

        public Animal() { }

        public Animal(string x, int y)
        {
            Name = x;
            Size = y;
        }
    }
}
