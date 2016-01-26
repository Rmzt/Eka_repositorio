using System;

namespace Demo3
{
    class Tietokone
    {
        //constructor
        public Tietokone(string naytonohjain_s, int ram_s, int virtalahde_s, string prosessori_s, string emolevy_s)
        {
            naytonohjain = naytonohjain_s;
            ram = ram_s;
            virtalahde = virtalahde_s;
            prosessori = prosessori_s;
            emolevy = emolevy_s;
        }


        public string Naytonohjain
        {
            get { return naytonohjain; }
            set { naytonohjain = value; }
        }
        public int Ram
        {
            get { return ram; }
            set { ram = value; }
        }

        public int Virtalahde
        {
            get { return virtalahde; }
            set { virtalahde = value; }

        }
        public string Prosessori
        {
            get { return prosessori; }
            set { prosessori = value; }
        }
        public string Emolevy
        {
            get { return emolevy; }
            set { emolevy = value; }
        }

        public override string ToString()
        {
            //base.ToString()
            return "Näytönohjain: " + naytonohjain.ToString() + "\nRam (gb): " + ram.ToString() + "\nVirtalähde (Watt): " + virtalahde.ToString() + "\nProsessori: " + prosessori.ToString() + "\nEmolevy: " + emolevy.ToString() + "\n";
        }

        private string naytonohjain;
        private int ram;
        private int virtalahde;
        private string prosessori;
        private string emolevy;
    }
    class Harj6
    {
        static void Main(string[] args)
        {
            int i;

            Tietokone[] tietokoneet = new Tietokone[5]
            {
            new Tietokone( "980ti", 16, 1000, "i5-4690K", "Emo1" ),
            new Tietokone( "Ati hd 5670", 4, 450, "AMD Phenom II x6 2.8ghz", "Emo2" ),
            new Tietokone( "970", 8, 750, "i5-4590K", "Emo3" ),
            new Tietokone( "Titan SLI", 32, 1500, "i7-6600K", "Emo4000" ),
            new Tietokone( "Titan quad-SLI", 64, 3000, "i7-uber", "Emo5000" )
            };

            for (i = 0; i < 5; i++)
                TulostaOsat(tietokoneet[i]);


            Console.ReadLine();
        }

        static void TulostaOsat(Tietokone tietokoneet)
        {
            Console.WriteLine(tietokoneet.ToString());

        }
    }
}
