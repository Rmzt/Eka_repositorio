using System;

namespace D4H5
{
    class Radio
    {
        public bool Onoff { get; set; }
        public int Volume
        {
            get { return volume; }
            set { if (value > 9) volume = 9; else if (value < 0) volume = 0; else volume = value; }
        }
        public float Frequency
        {
            get { return frequency; }
            set { if (value > 26000.0f) frequency = 26000.0f; else if (value < 2000.0f) frequency = 2000.0f ; else frequency = value; }
        }

        public Radio(bool onoff, int volume, float frequency)
        {
            Onoff = onoff;
            Volume = volume;
            Frequency = frequency;
        }

        public Radio() { }


        private int volume;
        private float frequency;
    }
}
