using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace OmegaStore.Models;

public partial class Order
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    [Column("order_code")]
    public string OrderCode { get; set; } = null!;

    [Required(ErrorMessage = "Họ và tên không được bỏ trống.")]
    [MaxLength(100)]
    [Column("fullname")]
    public string Fullname { get; set; } = null!;

    [EmailAddress(ErrorMessage = "Email không hợp lệ.")]
    [MaxLength(50)]
    [Column("email")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Số điện thoại không được bỏ trống.")]
    [RegularExpression(@"^(0[1-9]{1}[0-9]{8}|0[1-9]{2}[0-9]{7})$",
        ErrorMessage = "Số điện thoại không hợp lệ.")]
    [MaxLength(20)]
    [Column("phone")]
    public string Phone { get; set; } = null!;

    [Required(ErrorMessage = "Địa chỉ không được bỏ trống.")]
    [MaxLength(255)]
    [Column("address")]
    public string Address { get; set; } = null!;
    public DateTime? CreatedAt { get; set; } = DateTime.Now;

    [Required]
    [Column("total_amount", TypeName = "decimal(12,2)")]
    public decimal TotalAmount { get; set; }

    [Required]
    [Column("payment_method")]
    public bool PaymentMethod { get; set; }

    [MaxLength(500)]
    [Column("note")]
    public string? Note { get; set; }

    [Required]
    [Column("status")]
    public int Status { get; set; }

    // Thêm AccountId làm khóa ngoại
    public int? AccountId { get; set; }

    // Mối quan hệ với Account
    public virtual Account? Account { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<DetailOrder>? DetailOrders { get; set; } = new List<DetailOrder>();
}

