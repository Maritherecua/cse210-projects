// This class represents a shipping address for an order.
// It includes properties for street, city, state, and zip code.
// The GetFullAddress method returns the complete address as a formatted string.
namespace OnlineOrdering
{
    public class Address
    {
        private string _street;
        private string _city;
        private string _stateOrProvince;
        private string _country;

        public Address(string street, string city, string stateOrProvince, string country)
        {
            _street = street;
            _city = city;
            _stateOrProvince = stateOrProvince;
            _country = country;
        }

        public string GetFullAddress()
        {
            return $"{_street}, {_city}, {_stateOrProvince}, {_country}";
        }
        public bool IsInUSA()
        {
            return _country.ToUpper() == "USA" || _country.ToUpper() == "UNITED STATES";
        }

    }
}