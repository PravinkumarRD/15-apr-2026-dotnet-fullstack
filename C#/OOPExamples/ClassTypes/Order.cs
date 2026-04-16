namespace ClassTypes;

internal class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public int CustomerId { get; set; }
    public string Subscription { get; set; } = "Prime";
}
