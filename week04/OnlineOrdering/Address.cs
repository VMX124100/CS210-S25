public class Address
{
    public string Street;
    public string City;
    public string StateOrProvince;
    public string Country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        Street = street;
        City = city;
        StateOrProvince = stateOrProvince;
        Country = country;
    }

    // Returns true if the address is in the USA.
    public bool IsInUSA()
    {
        // A case-insensitive check for "USA" or "United States" can be done here.
        return Country.Equals("USA", StringComparison.OrdinalIgnoreCase)
            || Country.Equals("United States", StringComparison.OrdinalIgnoreCase);
    }

    // Returns a string representation of the address.
    public string FullAddress()
    {
        return $"{Street}\n{City}, {StateOrProvince}\n{Country}";
    }
}
