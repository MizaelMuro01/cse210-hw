public class Address
{
    public string street;
    public string city;
    public string state;
    public string country;

    public bool InUSA()
    {
        return country == "USA";
    }

    public string GetAddress()
    {
        return street + "\n" + city + ", " + state + "\n" + country;
    }
}