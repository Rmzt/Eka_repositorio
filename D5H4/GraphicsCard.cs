using System;

namespace D5H4
{
    class GraphicsCard
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int VRAM { get; set; }

        public GraphicsCard(string brand, string model, int vRAM)
        {
            Brand = brand;
            Model = model;
            VRAM = vRAM;
        }

        public override string ToString()
        {
            return "GraphicsCard: " + Brand + ", " + Model + ", " + VRAM;
        }
    }
}
