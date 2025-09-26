// This class represents a customer in the online ordering system.
// It includes properties for the customer's name and address.
// The GetName method returns the customer's name.
// The GetAddress method returns the customer's address.
// Returns whether the address is in the USA or international.
namespace OnlineOrdering
{
    public class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        public string GetName()
        {
            return _name;
        }

        public Address GetAddress()
        {
            return _address;
        }
        public bool IsInUSA()
        {
            return _address.IsInUSA();
        }

    }
}