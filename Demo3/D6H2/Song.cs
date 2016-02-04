using System;

namespace D6H2
{
    class Song
    {
        public string SongName { get; set; }

        public int Length
        {
            get { return length; }
            set { if (value < 0) length = 0; else length = value; }
        } 

        public Song(string songName, int length)
        {
            SongName = songName;
            Length = length;
        }

        public override string ToString()
        {
            return SongName + ", " + Length/60 + ":" + (Length - 60*(Length/60));
        }

        private int length;
    }
}
