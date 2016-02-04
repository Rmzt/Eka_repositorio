using System;
using System.Collections.Generic;

namespace D5H4
{
    class C_Computer
    {
        public List<GraphicsCard> Gpus { get; set; }
        public Processor CPU { get; set; }
        public List<RAM> Rams { get; set; }
        public string Case { get; set; }

        public void RemoveGraphicsCard()
        {
            Gpus.Clear();
        }

        public void AddGraphicsCard(GraphicsCard t)
        {
            Gpus.Add(t);
        }

        public void RemoveRAM()
        {
            Rams.Clear();
        }

        public void AddRAM(RAM t)
        {
            Rams.Add(t);
        }

        public C_Computer(string case_)
        {
            Case = case_;
            Gpus = new List<GraphicsCard>();
            Rams = new List<RAM>();
        }

        public override string ToString()
        {
            string s = "Case: " + Case + "\n" + CPU;

            foreach (GraphicsCard g in Gpus)
            {
                s += "\n";
                s += g.ToString();
            }

            foreach (RAM r in Rams)
            {
                s += "\n";
                s += r.ToString();
            }
            return s;
        }
    }
}
