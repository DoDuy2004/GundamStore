using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OmegaStore.Models;

public partial class Category
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Tự động tăng ID
    public int Id { get; set; }

    [Required(ErrorMessage = "Yêu cầu nhập tên danh mục")]
    [MaxLength(100)]
    [Column("name")]
    public string Name { get; set; } = null!;

    [MaxLength(100)]
    [Column("description")]
    public string? Description { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("slug")]
    public string Slug { get; set; } = null!;

    [Required]
    [Column("status")]
    public int Status { get; set; }
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
