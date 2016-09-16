using System;
using System.Collections.Generic;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        #region Private variables
        private string artist;
        private string label;
        private short released;
        private List<Track> tracks;
        #endregion

        #region Public properties
        public string Artist
        {
            get
            {
                return artist ?? string.Empty;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    artist = value;
                }
            }
        }

        public string Label
        {
            get
            {
                return label ?? string.Empty;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    label = value;
                }
            }
        }

        public short Released
        {
            get
            {
                return released;
            }
            set
            {
                if (value > 0)
                {
                    released = value;
                }
            }
        }

        public List<Track> Tracks
        {
            get
            {
                return tracks;
            }
        }
        #endregion

        public MusicCD()
        {
            this.tracks = new List<Track>();
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

        public TimeSpan GetPlayingTime()
        {
            TimeSpan retValue = new TimeSpan(0, 0, 0);
            foreach (Track track in tracks)
            {
                retValue += track.Length;
            }
            return retValue;
        }

    }
}