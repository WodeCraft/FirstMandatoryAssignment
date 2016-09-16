using System;

namespace MbmStore.Models
{
    public class Track
    {
        #region Private variables
        private string title;
        private TimeSpan length;
        private string composer;
        #endregion

        #region Public properties
        public string Title
        {
            get
            {
                return title ?? string.Empty;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    title = value;
                }
            }
        }

        public TimeSpan Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public string Composer
        {
            get
            {
                return composer ?? string.Empty;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    composer = value;
                }
            }
        }
        #endregion

        public Track()
        {

        }

        public Track(string title)
        {
            this.Title = title;
        }

    }
}