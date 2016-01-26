using System;

namespace PersonApplication
{

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public Person()
        {
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void PersonMethod()
        {
            Console.WriteLine("This method belons to Person!");
        }


        public override string ToString()
        {                
                return FirstName + " " + LastName + " " + Address + " " + Age + " " + PhoneNumber;           
        }
    }


}