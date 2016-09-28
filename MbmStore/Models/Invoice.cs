using System;
using System.Collections.Generic;

namespace MbmStore.Models
{
    public class Invoice
    {
        #region Private variables
        private int invoiceId;
        private DateTime orderDate;
        private Customer customer;
        private List<OrderItem> orderItems;
        private decimal totalPrice;
        #endregion

        #region Public properties
        public int InvoiceId
        {
            get
            {
                return invoiceId;
            }
            set
            {
                invoiceId = value;
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return orderDate;
            }
            set
            {
                orderDate = value;
            }
        }

        public decimal TotalPrice
        {
            get
            {
                return totalPrice;
            }
        }

        public Customer Customer
        {
            get
            {
                return customer;
            }
            set
            {
                if (value != null)
                {
                    customer = value;
                }
            }
        }

        public List<OrderItem> OrderItems
        {
            get
            {
                return orderItems;
            }
        }
        #endregion

        /// <summary>
        /// Default constructor with initializing values
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <param name="orderDate"></param>
        /// <param name="customer"></param>
        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            this.InvoiceId = invoiceId;
            this.OrderDate = orderDate;
            this.Customer = customer;
            totalPrice = 0m;
            orderItems = new List<OrderItem>();
        }

        /// <summary>
        /// Method for adding an OrderItem to an Invoice.
        /// As part of this the TotalPrice will also be updated by adding the 
        /// total price of the OrderItem to the total price of the Invoice.
        /// </summary>
        /// <param name="product">The product to be part of the OrderItem.</param>
        /// <param name="quantity">The quantity to be added.</param>
        public void AddOrderItem(Product product, int quantity)
        {
            OrderItem oi = new OrderItem(product, quantity);
            totalPrice += oi.TotalPrice;
            orderItems.Add(oi);
        }

    }
}