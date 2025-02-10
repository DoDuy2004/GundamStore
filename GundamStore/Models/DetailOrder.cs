using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OmegaStore.Models;

public partial class DetailOrder
{
    [Required]
    [Column("order_id")]
    public int OrderId { get; set; }

    [Required]
    [Column("product_id")]
    public int ProductId { get; set; }

    [Required]
    [Column("quantity")]
    public int Quantity { get; set; }

    [Required]
    [Column("total_price", TypeName = "decimal(12,2)")]
    public decimal TotalPrice { get; set; }

    public virtual Order? Order { get; set; } = null!;
    public virtual Product? Product { get; set; } = null!;
}

