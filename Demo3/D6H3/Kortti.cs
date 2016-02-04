using System;

namespace D6H3
{
    class Kortti
    {
        public string Maa { get; set; }

        public int Numero
        {
            get { return numero; }
            set { if (value < 0) numero = 0; else numero = value; }
        }

        public Kortti(string maa, int numero)
        {
            Maa = maa;
            Numero = numero;
        }

        public override string ToString()
        {
            string s = "";
            if (Numero <= 9)
                s += " ";
            s += Numero + " " + Maa;

            return s;
        }

        private int numero;
    }
}
