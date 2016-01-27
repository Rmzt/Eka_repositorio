using System;

namespace D4H5
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio eka = new Radio(false, -55, 0);
            Radio toka = new Radio(true, 10, 100000);
            Radio kolmas = new Radio(true, 7, 4856);

            Console.WriteLine(eka.Onoff + "\n" + eka.Volume + "\n" + eka.Frequency + "\n");
            Console.WriteLine(toka.Onoff + "\n" + toka.Volume + "\n" + toka.Frequency + "\n");
            Console.WriteLine(kolmas.Onoff + "\n" + kolmas.Volume + "\n" + kolmas.Frequency + "\n");

            Console.ReadLine();
        }
    }
}
