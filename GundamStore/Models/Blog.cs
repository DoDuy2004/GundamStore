using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GundamStore.Models;

public partial class Blog
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Tự động tăng 
    public int Id { get; set; }

    [Required]
    [MaxLength(255)]
    [Column("author")]
    public string Author { get; set; } = null!;

    [Required]
    [MaxLength(255)]
    [Column("title")]
    public string Title { get; set; } = null!;

    [Required]
    [MaxLength(255)]
    [Column("thumbnail")]   
    public string Thumbnail { get; set; } = null!;

    [Required]
    [MaxLength(255)]
    [Column("slug")]
    public string Slug { get; set; } = null!;
	public string? ListContent { get; set; }
	public string? ShortContent { get; set; }

    [Required]
    public string Content { get; set; } = null!;
    public DateTime? CreatedAt { get; set; } = DateTime.Now;
}

