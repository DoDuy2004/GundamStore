using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OmegaStore.Models;

public partial class WebsiteInfo
{
    [Key] // Khóa chính
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Tự động tăng
    [Column("id")]
    public int Id { get; set; }

    [StringLength(255)]
    [Column("contact_info")]
    public string? ContactInfo { get; set; }

    [Column("map")]
    public string? Map { get; set; }

    [Column("fanpage")]
    public string? Fanpage { get; set; }
    public string? Logo { get; set; }

    [NotMapped]
	public IFormFile? LogoUpload { get; set; }
}

