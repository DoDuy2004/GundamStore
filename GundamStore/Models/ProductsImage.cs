using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GundamStore.Models;

public partial class ProductsImage
{
    [Required]
    [Column("product_id")]
    public int ProductId { get; set; }

    [Required]
    [StringLength(255)]
    [Column("image")]
    public string Image { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}

