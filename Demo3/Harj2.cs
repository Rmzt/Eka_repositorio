using System;

namespace Demo3
{
    class Pesukone
    {
        //constructor 1
        public Pesukone(bool onkopaalla, int aikaajaljella, int valittuohjelma)
        {
            onoff = onkopaalla;
            kesto = aikaajaljella;
            ohjelma = valittuohjelma;
        }

        //constructor 2
        public Pesukone()
        {
            onoff = true;
        }

        //constructor 3
        public Pesukone(int valittuohjelma)
        {
            ohjelma = valittuohjelma;
        }

        public bool Status
        {
            get { return onoff; }
            set { onoff = value; }
        }
        public int KauankoKestaa
        {
            get { return kesto; }
            set { kesto = value; }
        }

        public int MikaOhjelma
        {
            get { return ohjelma; }
            set { ohjelma = value; }

        }

        private bool onoff;
        private int kesto;
        private int ohjelma;
    }
    class Harj2
    {
        static void Main(string[] args)
        {

            Pesukone eka = new Pesukone(true, 55, 1);

            Pesukone toka = new Pesukone();
            toka.Status = false;
            toka.KauankoKestaa = 0;
            toka.MikaOhjelma = 22;

            Pesukone kolmas = new Pesukone(3);
            kolmas.Status = false;
            kolmas.KauankoKestaa = 50;

            Pesukone neljas = new Pesukone { Status = true, KauankoKestaa = 30 };
            neljas.MikaOhjelma = 555;

            Console.WriteLine(" " + eka.Status);
            Console.WriteLine(" " + eka.KauankoKestaa);
            Console.WriteLine(" " + eka.MikaOhjelma);
            Console.WriteLine();
            Console.WriteLine(" " + toka.Status);
            Console.WriteLine(" " + toka.KauankoKestaa);
            Console.WriteLine(" " + toka.MikaOhjelma);
            Console.WriteLine();
            Console.WriteLine(" " + kolmas.Status);
            Console.WriteLine(" " + kolmas.KauankoKestaa);
            Console.WriteLine(" " + kolmas.MikaOhjelma);
            Console.WriteLine();
            Console.WriteLine(" " + neljas.Status);
            Console.WriteLine(" " + neljas.KauankoKestaa);
            Console.WriteLine(" " + neljas.MikaOhjelma);

            Console.ReadLine();
        }
    }
}
