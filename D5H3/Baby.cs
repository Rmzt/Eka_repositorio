using System;
using System.Collections.Generic;

namespace D5H3
{
    class Baby : Human
    {
        public string Diaper { get; set; }
        public override void Move(int amount)
        {
            Console.WriteLine("Baby is crawling");
        }
    }
}
