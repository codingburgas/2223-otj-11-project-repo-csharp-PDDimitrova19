using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace sms.dal.Models;

[Table("Store")]
public partial class Store
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    public int? ProductId { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("Stores")]
    public virtual Product? Product { get; set; }

    [InverseProperty("Store")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
