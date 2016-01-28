using System;

namespace D4H7
{
    class Snek : Animal
    {
        public bool Venom { get; set; }

        public Snek() { }

        public Snek(string name, int size, bool venom)
            : base(name, size)
        {
            Venom = venom;
        }

        //optional - no talk required
        public string Talk()
        {
            return "Hiss!";
        }
    }
}
