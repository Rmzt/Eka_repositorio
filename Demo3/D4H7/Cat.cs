using System;

namespace D4H7
{
    class Cat : Animal, IMammal
    {
        public int Legs { get; set; }
       
        public string Breed { get; set; }

        public Cat() { }

        public Cat(string name, int size, int legs, string breed)
            : base (name, size)
        {
            Legs = legs;
            Breed = breed;
        }

        // talk required
        public string Talk()
        {
            return "Miau!";
        }
    }
}
