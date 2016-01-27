using System;

namespace D4H6
{
    class Blu_ray : DataDisk
    {
        public override float DataAmount
        {
            get { return dataAmount; }
            set { if (value > 128000.0f) dataAmount = 128000.0f; else if (value < 0) dataAmount = 0; else dataAmount = value; }
        }

        public Blu_ray(string content, float dataAmount, float diameter)
            : base(content, dataAmount, diameter)
        {
            Content = content;
            DataAmount = dataAmount;
            Diameter = diameter;
        }

        public Blu_ray() { }
    }
}
