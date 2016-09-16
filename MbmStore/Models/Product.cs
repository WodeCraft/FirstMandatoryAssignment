namespace MbmStore.Models
{
    public class Product
    {
        #region Private variables
        private int productId;
        private string title;
        private decimal price;
        private string imageUrl;
        #endregion

        #region Public properties
        public int ProductId
        {
            get
            {
                return productId;
            }
            set
            {
                productId = value;
            }
        }
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
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
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
        #endregion

        public Product()
        {

        }

        public Product(string title, decimal price)
        {
            this.Title = title;
            this.Price = price;
        }
    }
}