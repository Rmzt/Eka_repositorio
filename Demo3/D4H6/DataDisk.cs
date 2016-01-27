using System;

namespace D4H6
{
    class DataDisk
    {
        public string Content { get; set; }
        public virtual float DataAmount
        {
            get { return dataAmount; }
            set { if (value > 0) dataAmount = value; else dataAmount = 0; }
        }
        public float Diameter
        {
            get { return diameter; }
            set { if (value > 0.0f) diameter = value;  else diameter = 0.0f; }
        }

        public DataDisk(string content, float dataAmount, float diameter)
        {
            Content = content;
            DataAmount = dataAmount;
            Diameter = diameter;
        }

        public DataDisk() { }


        protected float dataAmount;
        protected float diameter;
    }
}
