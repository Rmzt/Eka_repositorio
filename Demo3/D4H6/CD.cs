using System;

namespace D4H6
{
    class CD : DataDisk
    {
        public override float DataAmount
        {
            get { return dataAmount; }
            set { if (value > 700.0f) dataAmount = 700.0f; else if (value < 0) dataAmount = 0; else dataAmount = value; }
        }

        public CD(string content, float dataAmount, float diameter)
            : base (content, dataAmount, diameter)
        {
            Content = content;
            DataAmount = dataAmount;
            Diameter = diameter;
        }

        public CD() { }
    }
}
