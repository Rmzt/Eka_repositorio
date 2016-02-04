using System;
using System.Collections.Generic;

namespace D6H2
{
    class Program
    {
        static void Main(string[] args)
        {
            CD levy = new CD("Endless Forms Most Beautiful", "Nightwish");

            levy.AddSong(new Song("Shudder Before the Beautiful", 389));
            levy.AddSong(new Song("Weak Fantasy", 323));
            levy.AddSong(new Song("Elan", 285));
            levy.AddSong(new Song("Yours Is an Empty Hope", 334));

            Console.WriteLine(levy.ToString());






            CD levy2 = new CD("Testilevy", "Nightwish");

            levy2.AddSong(new Song("ASD", 100));
            levy2.AddSong(new Song("Final Fantasy", 1214));
            levy2.AddSong(new Song("Juu", 153));
            levy2.AddSong(new Song("Jep", 321));

            Console.WriteLine(levy2.ToString());



            Console.ReadLine();
        }
    }
}
