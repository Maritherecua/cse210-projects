//This class contains the name, product id, price and quantity of each product.
//computes the total cost of product multiplying the price per unit by the quantity.
namespace OnlineOrdering
{
    public class Product
    {
        private string _name;
        private string _productId;
        private double _price;
        private int _quantity;

        public Product(string name, string productId, double price, int quantity)
        {
            _name = name;
            _productId = productId;
            _price = price;
            _quantity = quantity;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetProductId()
        {
            return _productId;
        }

        public double GetPrice()
        {
            return _price;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public double TotalCost()
        {
            return _price * _quantity;
        }
    }
}