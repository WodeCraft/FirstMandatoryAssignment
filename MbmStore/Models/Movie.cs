namespace MbmStore.Models
{
    public class Movie : Product
    {
        #region Private fields
        private string director;
        private string producer;
        #endregion

        #region Public properties

        public string Director
        {
            get { return director; }
        }

        public string Producer
        {
            get
            {
                return producer ?? string.Empty;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    producer = value;
                }
            }
        }
        #endregion

        // constructors
        public Movie(string title, decimal price) : base(title, price)
        {
        }

        public Movie(string title, decimal price, string imageUrl, string director) : base(title, price)
        {
            this.ImageUrl = imageUrl;
            this.director = director;
        }
    }
}