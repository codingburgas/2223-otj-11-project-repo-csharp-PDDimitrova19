using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace sms.dal.Models;

[Table("Product")]
public partial class Product
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string ProductName { get; set; } = null!;

    [StringLength(50)]
    public string Brand { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime ExpiryDate { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal Price { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();

    [InverseProperty("Product")]
    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();
}
