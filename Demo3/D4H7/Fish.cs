using System;

namespace D4H7
{
    class Fish : Animal
    {
        public int SwimSpeed { get; set; }

        public Fish() { }

        public Fish(string name, int size, int swimSpeed)
            : base(name, size)
        {
            SwimSpeed = swimSpeed;
        }

        //no talk required
    }
}
