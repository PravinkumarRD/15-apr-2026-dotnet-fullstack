namespace ClassTypes;

internal abstract class Person
{
    protected Person()
    {
        Console.WriteLine("Abstract Class Constructor Executed!");
    }
    public int SocialId { get; set; }
    public string ContactName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;

    public abstract bool ChangeAddress(int socialId, string newAddress);
}
