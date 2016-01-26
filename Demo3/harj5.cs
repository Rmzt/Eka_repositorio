using System;

namespace Demo3
{
    class Opiskelija
    {
        //constructor
        public Opiskelija(string nimi_s, int ika_s, int sukupuoli_s, string opnum_s, string ryhma_s)
        {
            nimi = nimi_s;
            ika = ika_s;
            sukupuoli = sukupuoli_s;
            opnum = opnum_s;
            ryhma = ryhma_s;
    }


        public string Nimi
        {
            get { return nimi; }
            set { nimi = value; }
        }
        public int Ika
        {
            get { return ika; }
            set { ika = value; }
        }

        public int Sukupuoli
        {
            get { return sukupuoli; }
            set { sukupuoli = value; }

        }
        public string Opnum
        {
            get { return opnum; }
            set { opnum = value; }
        }
        public string Ryhma
        {
            get { return ryhma; }
            set { ryhma = value; }
        }

        public override string ToString()
        {
            //base.ToString()
            return "Nimi: " + nimi.ToString() + "\nIkä: " + ika.ToString() + "\nSukupuoli: " + sukupuoli.ToString() + "\nOpiskelijanumero: " + opnum.ToString() + "\nRyhma: " + ryhma.ToString() + "\n";
        }

        private string nimi;
        private int ika;
        private int sukupuoli;
        private string opnum;
        private string ryhma;
    }
    class Harj5
    {
        static void Main(string[] args)
        {
            int i;

            Opiskelija[] opiskelijat = new Opiskelija[5] 
            {
            new Opiskelija( "Matti Meikäläinen", 18, 0, "K1234", "Ryhmä1" ),
            new Opiskelija( "Tarja Meikäläinen", 19, 1, "K1235", "Ryhmä1" ),
            new Opiskelija( "Jaana Keijonen", 28, 1, "K1236", "Ryhmä2" ),
            new Opiskelija( "Seppo Taalasmaa", 38, 0, "K1237", "Ryhmä4" ),
            new Opiskelija( "Ismo Laitela", 21, 0, "K1238", "Ryhmä1" )
            };

            for (i=0;i<5;i++)
            TulostaOpiskelijat(opiskelijat[i]);


            Console.ReadLine();
        }

        static void TulostaOpiskelijat(Opiskelija opiskelijat)
        {
            Console.WriteLine(opiskelijat.ToString());

        }
    }
}
