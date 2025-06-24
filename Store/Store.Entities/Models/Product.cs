using System.ComponentModel.DataAnnotations;

namespace Store.Entities.Models;

public class Product
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Product name is required")]
    public string? Name { get; set; } = string.Empty;
    [Required(ErrorMessage = "Product Price is required")]
    public decimal Price { get; set; }
}