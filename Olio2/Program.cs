using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio2
{
    /*
    class Point
    {
        public int x;
        public int y;
    }*/
    
    class Car
    {
        //constructor
        public Car(string modelToSet, int engineSize)
        {
            model = modelToSet;
            cc = engineSize;
        }

        public int EngineSize
        {
            get { return cc; }
        }

        public string ModelProperty
        {
            get { return model; }
            set { model = value; }
            
        }

        // class private members - DO NOT TOUCH
        private string model;
        private readonly int cc;
        private const int maxSpeed = 10;
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            /*
            Point coordinate = new Point();
            coordinate.x = 100;
            coordinate.y = 50;

            ModifyPoint(coordinate);

            Console.WriteLine("coordinate is: " + coordinate.x + "," + coordinate.y);
            */
            
            Car[] toyotas = new Car[1000];
            for (int i=0; i<1000; i++)
            {
                toyotas[i] = new Car("avensis", 1895);
            }
            
            Car toyota = new Car("avensis", 1895);
            Car toyota2 = new Car("corolla", 1599);
            Car toyota3 = new Car("gt86", 1999);

            Console.WriteLine("This toyota model is: " + toyota.ModelProperty);
            Console.WriteLine("This toyota engine size is: " + toyota.EngineSize);
            
            Console.WriteLine("This toyota model is: " + toyota2.ModelProperty);
            Console.WriteLine("This toyota engine size is: " + toyota2.EngineSize);

            Console.WriteLine("This toyota model is: " + toyota3.ModelProperty);
            Console.WriteLine("This toyota engine size is: " + toyota3.EngineSize);
            
            Console.ReadLine();
        }
        /*
        static void ModifyPoint(Point p)
        {
            p.x += 500;
            p.y += 1500;
        }
        */
    }
}
