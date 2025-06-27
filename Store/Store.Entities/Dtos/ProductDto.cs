using System.ComponentModel.DataAnnotations;
using Store.Entities.Models;

namespace Store.Entities.Dtos;

public record ProductDto
{
    public int Id { get; init; }
    [Required(ErrorMessage = "Product name is required")]
    
    public string? Name { get; init; } = string.Empty;
  
    [Required(ErrorMessage = "Product Price is required")]
    public decimal Price { get; init; }

    public int? CategoryId { get; init; }
}