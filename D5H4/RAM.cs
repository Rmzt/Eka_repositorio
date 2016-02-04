using System;

namespace D5H4
{
    class RAM
    {
        public int DDRtype {
            get { return dDRtype; }
            set { if (value > 0 && value < 5) dDRtype = value; else dDRtype = 0; }
        }
        public int Size { get; set; }
        public int Speed { get; set; }

        public RAM(int dDRtype, int size, int speed)
        {
            DDRtype = dDRtype;
            Size = size;
            Speed = speed;
        }

        public override string ToString()
        {
            return "RAM: " + DDRtype + ", " + Size + ", " + Speed;
        }

        private int dDRtype;
    }
}
