using System;

namespace D4H6
{
    class DVD : DataDisk
    {
        public override float DataAmount
        {
            get { return dataAmount; }
            set { if (value > 17080.0f) dataAmount = 17080.0f; else if (value < 0) dataAmount = 0; else dataAmount = value; }
        }

        public DVD(string content, float dataAmount, float diameter)
            : base(content, dataAmount, diameter)
        {
            Content = content;
            DataAmount = dataAmount;
            Diameter = diameter;
        }

        public DVD() { }
    }
}
