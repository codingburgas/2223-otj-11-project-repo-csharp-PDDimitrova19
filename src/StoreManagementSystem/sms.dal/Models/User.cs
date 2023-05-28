using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace sms.dal.Models;

public partial class User
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [StringLength(50)]
    public string LastName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string EmailAddress { get; set; } = null!;

    [StringLength(64)]
    public string Password { get; set; } = null!;

    public int? StoreId { get; set; }

    public bool IsAdmin { get; set; }

    [StringLength(50)]
    public string Username { get; set; } = null!;

    [ForeignKey("StoreId")]
    [InverseProperty("Users")]
    public virtual Store? Store { get; set; }
}
