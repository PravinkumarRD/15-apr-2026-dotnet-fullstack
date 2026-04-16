namespace ClassTypes;

//PrimeCustomer IS-A Customer
internal sealed class PrimeCustomer : Customer
{
    public PrimeCustomer()
    {
        Console.WriteLine("PrimeCustomer Class Constructor Executed!");
    }
    public double PrimeFees { get; set; } = 1499;
}