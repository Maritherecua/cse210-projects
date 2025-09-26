// This class represents an order containing a list of products and a customer name.
// It provides methods,to calculate the total order cost, returns a string for the packing label
// the packing label lists each product's name and id.
// and a string for the shipping label with the customer's name and address.
// total order cost includes a flat shipping fee based on whether the customer is in the USA or not.
// The shipping fee is $5 for USA and $35 for international orders.
// the total cost of the order is the sum of the total cost of each product plus the shipping fee.
using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> _products;
        private string _customerName;
        private string _shippingAddress;

        public Order(string customerName, string shippingAddress)
        {
            _products = new List<Product>();
            _customerName = customerName;
            _shippingAddress = shippingAddress;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public double CalculateTotalCost()
        {
            double total = 0;
            foreach (var product in _products)
            {
                total += product.TotalCost();
            }

            // Add shipping fee
            if (_shippingAddress.Contains("USA"))
            {
                total += 5; // Flat fee for USA
            }
            else
            {
                total += 35; // Flat fee for international
            }

            return total;
        }

        public string GetPackingLabel()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Packing Label:");
            foreach (var product in _products)
            {
                sb.AppendLine($"- {product.GetName()} (ID: {product.GetProductId()})");
            }
            return sb.ToString();
        }

        public string GetShippingLabel()
        {
            return $"Shipping Label:\nCustomer: {_customerName}\nAddress: {_shippingAddress}";
        }
    }
}