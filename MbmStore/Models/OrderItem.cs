using System;

namespace MbmStore.Models
{
    public class OrderItem
    {
        #region Private variables
        private int orderItemId;
        private int productId;
        private Product product;
        private int quantity;
        #endregion

        #region Public properties
        public int OrderItemId
        {
            get
            {
                return orderItemId;
            }
            set
            {
                orderItemId = value;
            }
        }

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

        public Product Product
        {
            get
            {
                return product;
            }
            set
            {
                if (value != null)
                {
                    product = value;
                }
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public decimal TotalPrice
        {
            get
            {
                return decimal.Multiply(Product.Price, Quantity);
            }
        }
        #endregion

        public OrderItem(Product product, int quantity)
        {
            Random rnd = new Random();
            this.orderItemId = rnd.Next(1000, 10000);
            this.Product = product;
            this.productId = product.ProductId;
            this.Quantity = quantity;
        }

    }
}