using System;
namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Person somebody = new Person();
            somebody.FirstName = "Joe";
            somebody.LastName = "Dirt";
            somebody.Address = "Unknown";
            somebody.Age = 29;
            somebody.PhoneNumber = "040-2424234324324";
            Console.WriteLine(somebody.ToString());

            Teacher teacher = new Teacher();
            teacher.FirstName = "Jani";
            teacher.LastName = "Immonen";
            teacher.Address = "Koding";
            teacher.Age = 21;
            teacher.PhoneNumber = "Unknown";
            teacher.Room = "D330";
            Console.WriteLine(teacher.ToString());

            Student theStudent = new Student("Pekka", "Pouta", "J23432432432");
            theStudent.Address = "Kilju 3";
            theStudent.Age = 39;
            theStudent.PhoneNumber = "23432432432324";
            Console.WriteLine(theStudent.ToString());

            somebody.PersonMethod();
            teacher.PersonMethod();
            teacher.TeacherMethod();
            theStudent.PersonMethod();
            theStudent.StudentMethod();
            

            Console.ReadLine();

        }
    }
}