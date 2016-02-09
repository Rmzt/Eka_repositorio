using System;
using System.Collections.Generic;

namespace D7
{
    class Car
    {
        public string Brand { get; }
        public string Model { get; }

        public Car(string brand, string model)
        {
            if (brand.Equals(""))
            {
                throw new CarException("Car brand can't be empty!");
            }
            if (model.Equals(""))
            {
                throw new CarException("Car model can't be empty!");
            }
            Brand = brand;
            Model = model;
        }
    }
}
