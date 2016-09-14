using System;
using System.Collections.Generic;

namespace MbmStore.Models
{
    public class Invoice
    {
        private decimal totalPrice;

        private List<OrderItem> orderItems;

        public int InvoiceId { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return 0m;
            }
        }

        public Customer Customer { get; set; }

        public List<OrderItem> OrderItems
        {
            get
            {
                return orderItems;
            }
        }

        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            this.InvoiceId = invoiceId;
            this.OrderDate = orderDate;
            this.Customer = customer;
            orderItems = new List<OrderItem>();
        }

        public void AddOrderItem(Product product, int quantity)
        {
            orderItems.Add(new OrderItem(product, quantity));
        }

    }
}