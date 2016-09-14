using System.Collections.Generic;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {

        private List<Track> tracks;


        public string Artist { get; set; }

        public string Label { get; set; }

        public short Released { get; set; }

        public List<Track> Tracks
        {
            get
            {
                if (tracks == null)
                {
                    tracks = new List<Track>();
                }
                return tracks;
            }
        }

        public MusicCD()
        {

        }

        public MusicCD(string artist, string title, decimal price, short released)
            : base(title, price)
        {
            this.Artist = artist;
            this.Released = released;
            this.tracks = new List<Track>();
        }

        public void AddTrack(Track track)
        {
            if (track != null)
            {
                tracks.Add(track);
            }
        }

    }
}