public class Customer
{
    public string name;
    public Address address;

    public bool InUSA()
    {
        return address.InUSA();
    }
}