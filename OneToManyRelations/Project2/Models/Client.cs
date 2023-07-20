using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Filip;

public partial class Client
{
    [Key]
    public int ClientId { get; set; }

    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [StringLength(50)]
    public string LastName { get; set; } = null!;

    [InverseProperty("Client")]
    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
