using System.ComponentModel.DataAnnotations;

namespace Bajaj.eCommerce.Entities;

public class Invoice
{
    [Key]
    public int InvoiceId { get; set; }
    public DateTime InvoiceDate { get; set; } = DateTime.Now;
    public int CartId { get; set; }
    public Cart Cart { get; set; }
}
