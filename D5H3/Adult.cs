using System;
using System.Collections.Generic;

namespace D5H3
{
    class Adult : Human
    {
        public string Car { get; set; }

        public override void Move(int amount)
        {
            Console.WriteLine("Adult is walking");
        }
    }
}
