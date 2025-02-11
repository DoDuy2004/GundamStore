using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GundamStore.Models;

public partial class Contact
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Tự động tăng ID
    public int ContactId { get; set; }

    [Required(ErrorMessage = "Vui lòng nhập email của bạn!")]
    [EmailAddress(ErrorMessage = "Định dạng email không hợp lệ.")]
    [MaxLength(50)]
    [Column("email")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Vui lòng nhập tên của bạn")]
    [MaxLength(100)]
    [Column("fullname")]
    public string Fullname { get; set; } = null!;

    [Required(ErrorMessage = "Nhập chủ đề bạn cần hỗ trợ")]
    [MaxLength(100)]
    [Column("subject")]
    public string Subject { get; set; } = null!;

    [MaxLength(500)]
    [Column("message")]
    public string? Message { get; set; } = null!;

    public DateTime? CreatedAt { get; set; } = DateTime.Now;

    [Required]
    [Column("status")]
    public RequestStatus Status { get; set; } = RequestStatus.Unresolved;
    public string? OrderCode { get; set; }
}

public enum RequestStatus
{
    Resolved = 1,  // Đã giải quyết
    Unresolved = 0 // Chưa giải quyết
}