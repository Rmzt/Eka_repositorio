using System;

namespace D5H4
{
    class Processor
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ClockRate { get; set; }

        public Processor(string brand, string model, int clockRate)
        {
            Brand = brand;
            Model = model;
            ClockRate = clockRate;
        }

        public override string ToString()
        {
            return "Processor: " + Brand + ", " + Model + ", " + ClockRate;
        }
    }
}
