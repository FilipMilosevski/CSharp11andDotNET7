using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Filip;

public partial class Account
{
    [Key]
    public int AccountId { get; set; }

    public int? AccountTypeId { get; set; }

    public int? ClientId { get; set; }

    [Column(TypeName = "decimal(15, 2)")]
    public decimal Balance { get; set; }

    [ForeignKey("AccountTypeId")]
    [InverseProperty("Accounts")]
    public virtual AccountType? AccountType { get; set; }

    [ForeignKey("ClientId")]
    [InverseProperty("Accounts")]
    public virtual Client? Client { get; set; }
}
