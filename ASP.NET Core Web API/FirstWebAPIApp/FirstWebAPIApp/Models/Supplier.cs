namespace FirstWebAPIApp.Models;

public class Supplier
{
    public int SupplierId { get; set; }
    public string Owner { get; set; } = string.Empty;
    public string CompanyName { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public int Zipcode { get; set; }
}
