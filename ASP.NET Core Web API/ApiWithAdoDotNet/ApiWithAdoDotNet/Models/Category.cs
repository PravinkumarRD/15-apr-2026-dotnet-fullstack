using System.ComponentModel.DataAnnotations;

namespace ApiWithAdoDotNet.Models;

public class Category
{
    public int CategoryId { get; set; }
    [Required(ErrorMessage ="Category Name is a required field!")]
    [MaxLength(50,ErrorMessage = "Category Name can not exceed 50 characters!")]
    public string CategoryName { get; set; } = string.Empty;
    [Required(ErrorMessage = "Category Description is a required field!")]
    [MaxLength(200, ErrorMessage = "Category Description can not exceed 200 characters!")]
    public string Description { get; set; } = string.Empty;
}
