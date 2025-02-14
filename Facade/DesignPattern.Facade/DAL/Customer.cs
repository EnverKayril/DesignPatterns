﻿namespace DesignPattern.Facade.DAL
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }
        public IList<Order> Orders { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
