using System;
using System.Collections.Generic;

namespace D5H4
{
    class Program
    {
        static void Main(string[] args)
        {
            C_Computer computa = new C_Computer("Fractal Design R5");

            Processor prossu = new Processor("Intel", "i5-4690K", 3500);
            computa.CPU = prossu;
            // computa.CPU = new Processor("Intel", "i5-4690K", 3500);

            computa.AddGraphicsCard(new GraphicsCard("Nvidia", "GTX 980ti", 6));
            computa.AddGraphicsCard(new GraphicsCard("Nvidia", "GTX 980ti", 6));

            computa.AddRAM(new RAM(3, 8192, 1866));
            computa.AddRAM(new RAM(3, 8192, 1866));
            computa.AddRAM(new RAM(3, 8192, 1866));
            computa.AddRAM(new RAM(3, 8192, 1866));

            Console.WriteLine(computa.ToString());

            Console.ReadLine();
        }
    }
}
