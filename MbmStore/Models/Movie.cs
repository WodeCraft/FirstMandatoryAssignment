using System;

namespace MbmStore.Models
{
    public class Movie
    {
        #region Private fields
        private string title;
        private decimal price;
        private string director;
        private string imageUrl;
        private string producer;
        #endregion

        #region Public properties
        public string Title
        {
            get { return title; } // read
        }

        public decimal Price
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else
                {
                    price = value;
                }
            }
            get { return price; }
        }


        public string ImageUrl
        {
            get
            {
                return imageUrl ?? string.Empty;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    imageUrl = value;
                }
            }
        }

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
        public Movie(string title, decimal price)
        {
            this.title = title;
            this.price = price;
        }

        public Movie(string title, decimal price, string imageUrl, string director)
        {
            this.title = title;
            this.price = price;
            ImageUrl = imageUrl;
            this.director = director;
        }
    }
}