using System;

namespace Demo3
{
    class Kiuas
    {
        //constructor
        public Kiuas(bool onkopaalla, int lampotila, int kosteusmaara)
        {
            onoff = onkopaalla;
            lampo = lampotila;
            kosteus = kosteusmaara;
        }

        public bool Status
        {
            get { return onoff; }
            set { onoff = value; }
        }
        public int Kuumuus
        {
            get { return lampo; }
            set { lampo = value; }
        }

        public int Kosteus
        {
            get { return kosteus; }
            set { kosteus = value; }

        }

        private bool onoff;
        private int lampo;
        private int kosteus;
    }
    class Harj1
    {
        static void Main(string[] args)
        {

            Kiuas eka = new Kiuas(true, 80, 50);

            Console.WriteLine(" " + eka.Status);
            Console.WriteLine(" " + eka.Kuumuus);
            Console.WriteLine(" " + eka.Kosteus);

            Console.ReadLine();
        }
    }
}
