using System;
using System.Collections.Generic;

namespace D6H3
{
    class Pakka
    {
        public List<Kortti> Kortit { get; set; }

        public void RemoveKortti()
        {
            Kortit.Clear();
        }

        public void AddKortti(Kortti t)
        {
            Kortit.Add(t);
        }


        public Pakka()
        {
            Kortit = new List<Kortti>();

            for (int i=1; i<=13; i++)
            {
                AddKortti(new Kortti("Hertta", i));
            }
            for (int i = 1; i <= 13; i++)
            {
                AddKortti(new Kortti("Risti", i));
            }
            for (int i = 1; i <= 13; i++)
            {
                AddKortti(new Kortti("Ruutu", i));
            }            
            for (int i = 1; i <= 13; i++)
            {
                AddKortti(new Kortti("Pata", i));
            }
        }

        public override string ToString()
        {
            string s = "";

            foreach (Kortti k in Kortit)
            {                
                s += k.ToString();
                s += "\n";
            }

            return s;
        }

        /*
        public void RandomString()
        {





            string s = "";

            foreach (Kortti k in Kortit)
            {
                s += k.ToString();
                s += "\n";
            }

            Console.WriteLine(s);
        }
        */
    }
}
