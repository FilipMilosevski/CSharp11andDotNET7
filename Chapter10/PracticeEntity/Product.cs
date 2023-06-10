﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared;

public class Product
{
    public int ProductId { get; set; }


    [Required]
    [StringLength(40)]
    public string ProductName { get; set; }


    [Column("UnitPrice",TypeName ="Money")]
    public decimal? Cost { get; set; }


    [Column("UnitsInStock")]
    public short?  Stock { get; set; }

    public bool Discontinued { get; set; }

    public int CategoryID { get; set; }

    public virtual Category Category { get; set; } = null!;
}
