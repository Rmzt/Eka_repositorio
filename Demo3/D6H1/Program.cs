using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace D6H1
{
    class Program
    {                
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person("12345-5253", "Pekka", "Pouta", 39, 78, 183));
            persons.Add(new Person("32145-5653", "Seppo", "Pouta1", 28, 85, 178));
            persons.Add(new Person("1221125-5453", "Ismo", "Pouta4", 19, 115, 220));
            persons.Add(new Person("1567445-5523", "Aki", "Pouta5", 70, 115, 192));
            persons.Add(new Person("1543654345-553", "Timo", "Pouta2", 22, 140, 180));
            persons.Add(new Person("12132421-5513", "Keijo", "Pouta6", 52, 95, 185));
            persons.Add(new Person("12432345-5453", "Milla", "Saari", 33, 55, 162));
            persons.Add(new Person("122345-5543", "Laura", "Kinnunen", 53, 60, 159));
            /*
            foreach (Person somebody in persons)
            {
                Console.Write(somebody.ToString());
            }
            */

            persons.Sort((x, y) => x.Age.CompareTo(y.Age));

            foreach (Person somebody in persons)
            {
                Console.Write(somebody.ToString());
            }

            // try to find a person...
            //string SSN = "154355545-553";
            Person found = persons.Find(x => x.Age == 19);
            if (found != null)
            {
                Console.WriteLine("Person found!");
                persons.Remove(found);
            }
            else
            {
                Console.WriteLine("Person not found!");
            }

            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i].Age == 1)
                {
                    persons.RemoveAt(70);
                    i = -1;
                    Console.WriteLine("asd");
                }
            }

            /*
            foreach (Person somebody in persons)
            {
                if (somebody.SSN == SSN)
                {
                    Console.WriteLine("Person with SSN " + SSN + " FOUND!");
                    break;
                }
            }
            */

            Console.ReadLine();
        }
    }
}






