using System;

namespace D4H7
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat kissa = new Cat("Mirri", 60, 4, "Persian");
            Snek kaarme = new Snek("Snek", 100, false);
            Fish kala = new Fish("Sushi", 5, 20);

            Console.WriteLine(kissa.Name + ", " + kissa.Size + ", " + kissa.Legs + ", " + kissa.Breed + ", " + kissa.Talk());
            Console.WriteLine(kaarme.Name + ", " + kaarme.Size + ", " + kaarme.Venom + ", " + kaarme.Talk());
            Console.WriteLine(kala.Name + ", " + kala.Size + ", " + kala.SwimSpeed);

            Console.ReadLine();
        }
    }
}
