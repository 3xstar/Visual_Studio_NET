using System;
using System.Collections.Generic;
using System.Text;

namespace linq
{
    internal class base4
    {
        static void Main4(string[] args)
        {
            List<Order> orders = new List<Order>()
            {
                new Order(1, "Vlad", new List<string>() { "Product1", "Product2" }),
                new Order(2, "Ira", new List<string>() { "Product3" }),
                new Order(3, "Vova", new List<string>() { "Product4", "Product5", "Product6" }),
            };

            var productsByCustomer = orders.SelectMany(o => o.Products);

            foreach (var product in productsByCustomer)
            {
                Console.WriteLine(product);
            }

            var products = orders.SelectMany(o => o.Products,
                (customer, item) => new
                {
                    Customer = customer.Customer,
                    Product = item
                }
                );

            foreach (var product in products)
            {
                Console.WriteLine(product.Customer);

                Console.WriteLine(product.Product);
            }
        }
    }

    class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public List<string> Products { get; set; }

        public Order(int id, string customer, List<string> products)
        {
            Id = id;
            Customer = customer;
            Products = products;
        }
    }
}
