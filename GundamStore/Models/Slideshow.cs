using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OmegaStore.Models;

public partial class Slideshow
{
    [Key] // Khóa chính
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Tự động tăng
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [StringLength(255)]
    [Column("image")]
    public string Image { get; set; } = null!;

    [Required]
    [StringLength(255)]
    [Column("link")]
    public string Link { get; set; } = null!;
}

