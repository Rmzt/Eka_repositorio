using System;
using System.Collections.Generic;

namespace D6H2
{
    class CD
    {
        public List<Song> Songs { get; set; }
        public string AlbumName { get; set; }
        public string Artist { get; set; }

        public void RemoveSong()
        {
            Songs.Clear();
        }

        public void AddSong(Song t)
        {
            Songs.Add(t);
        }


        public CD(string albumName, string artist)
        {
            AlbumName = albumName;
            Artist = artist;
            Songs = new List<Song>();
        }

        public override string ToString()
        {
            string s = "CD data:\n- Name: " + AlbumName + "\n- Artist: " + Artist + "\n- Songs:";

            foreach (Song g in Songs)
            {
                s += "\n  - ";
                s += g.ToString();
            }

            s += "\n";
            return s;
        }
    }
}
