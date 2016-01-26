using System;

namespace PersonApplication
{
    class Teacher : Person
    {
        public string Room { get; set; }

        public Teacher()
        {
        }

        public Teacher(string firstName, string lastName, string room)
            : base(firstName ,lastName)
        {
            Room = room;
        }

        public void TeacherMethod()
        {
            Console.WriteLine("This method belongs to Teacher!");
        }

        public override string ToString()
        {
            return base.ToString() + " " + Room;
        }
    }
}
