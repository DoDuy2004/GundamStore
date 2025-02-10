using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OmegaStore.Models;

public partial class Role
{
    [Key] // Khóa chính
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Tự động tăng
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    [Column("name")]
    public string Name { get; set; } = null!;

    [StringLength(100)]
    [Column("description")]
    public string? Description { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}

