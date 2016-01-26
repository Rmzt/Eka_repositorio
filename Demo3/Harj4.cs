using System;

namespace Demo3
{
    class Vehicle
    {
        //constructor
        public Vehicle(string nimi, int nopeus, int renkaat)
        {
            name = nimi;
            speed = nopeus;
            tyres = renkaat;
        }

  
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public int Tyres
        {
            get { return tyres; }
            set { tyres = value; }

        }

        public override string ToString()
        {
            //base.ToString()
            return  "Nimi: " + name.ToString() + "\nNopeus: " + speed.ToString() + "\nRenkaat: " + tyres.ToString();
        }

        private string name;
        private int speed;
        private int tyres;
    }
    class Harj4
    {
        static void Main(string[] args)
        {

            Vehicle eka = new Vehicle("Audi", 80, 3);

            PrintData(eka);

            
            
            

            Console.ReadLine();
        }

        static void PrintData(Vehicle eka)
        {
            Console.WriteLine(eka.ToString());

        }
    }
}
