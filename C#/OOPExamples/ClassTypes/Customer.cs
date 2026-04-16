namespace ClassTypes;

//Customer IS-A Person
internal class Customer : Person
{
    public Customer()
    {
        Console.WriteLine("Customer Class Constructor Executed!");
    }
    public int CustomerId { get; set; }
    protected string Preference { get; set; } = string.Empty;
    public override bool ChangeAddress(int socialId, string newAddress)
    {
        Console.WriteLine($"{ContactName} has changed his/her address from {Address} to new address {newAddress}!");
        return true;
    }
}
