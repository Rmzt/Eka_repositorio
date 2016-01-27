using System;

namespace D4H6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataDisk eka = new CD("Musiikkia", 750, 12);
            DVD toka = new DVD("Pelejä", 100000000, 12);
            DataDisk kolmas = new Blu_ray("Elokuvia", 100000000, -5);

            Console.WriteLine(eka.Content + "\n" + eka.DataAmount + "\n" + eka.Diameter + "\n");
            Console.WriteLine(toka.Content + "\n" + toka.DataAmount + "\n" + toka.Diameter + "\n");
            Console.WriteLine(kolmas.Content + "\n" + kolmas.DataAmount + "\n" + kolmas.Diameter + "\n");

            Console.ReadLine();
        }
    }
}
