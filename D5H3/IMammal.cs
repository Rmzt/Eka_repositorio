using System;
using System.Collections.Generic;

namespace D5H3
{
    abstract class IMammal
    {
        public int Age { get; set; }

        abstract public void Move(int amount);
        /*
        {
            Console.WriteLine("Mammal is moving " + amount + " steps");
        }
        */
    }
}
