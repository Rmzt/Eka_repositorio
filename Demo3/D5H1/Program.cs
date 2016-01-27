using System;

namespace D5H1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle mycar = new Vehicle("Toyota", "Purkki");
            Console.WriteLine(mycar.ToString());

            mycar.RemoveTyres();
            Console.WriteLine(mycar.ToString());

            mycar.AddTyre(new Tyre("Nokia", "Hakkaapäälle", "19S/65R15"));
            mycar.AddTyre(new Tyre("Nokia", "Hakkaapäälle", "19S/65R15"));
            mycar.AddTyre(new Tyre("Nokia", "Hakkaapäälle", "19S/65R15"));
            Console.WriteLine(mycar.ToString());

            Console.ReadLine();
        }
    }
}
