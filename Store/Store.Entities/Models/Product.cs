﻿using System.ComponentModel.DataAnnotations;

namespace Store.Entities.Models;

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string? Summary { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }
}