
using System;
using System.Collections.Generic;


namespace HIOF.V2025.Arbeidskrav1.BookStore
{
    /// <summary>
    /// Represents an order in the bookstore
    /// </summary>
    public class Order
    {
        /// <summary>
        /// The ID of the order
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// The books in the order
        /// </summary>
        public List<Book> Books { get; set; }
        /// <summary>
        /// The customer who made the order
        /// </summary>
        public Customer Customer { get; set; }
        /// <summary>
        /// The date and time the order was made
        /// </summary>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// The total price of the order
        /// </summary>
        public double TotalPrice { get; set; }

        /// <summary>
        /// Creates a new instance of order
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="books"></param>
        /// <param name="customer"></param>
        /// <param name="orderDate"></param>
        /// <param name="totalPrice"></param>
        public Order(int orderId, List<Book> books, Customer customer, DateTime orderDate, double totalPrice)
        {
            OrderId = orderId;
            Books = books;
            Customer = customer;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
        }

        /// <summary>
        /// Returns a string representation of the order
        /// </summary>
        public override string ToString()
        {
            return $"Order ID: {OrderId}, Customer: {Customer.FirstName} {Customer.LastName}, Order Date: {OrderDate}, Total Price: {TotalPrice:C}";
        }
    }

}
