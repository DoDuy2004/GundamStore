using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace OmegaStore.Models;

public partial class Review
{
    [Required(ErrorMessage = "Vui lòng chọn sản phẩm.")]
    [Column("product_id")]
    public int ProductId { get; set; }

    [Required(ErrorMessage = "Vui lòng nhập email.")]
    [EmailAddress(ErrorMessage = "Định dạng email không hợp lệ.")]
    [StringLength(50)]
    [Column("email")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Vui lòng nhập họ tên.")]
    [StringLength(100, ErrorMessage = "Họ tên không được vượt quá 100 ký tự.")]
    [Column("fullname")]
    public string Fullname { get; set; } = null!;

    [Range(1, 5, ErrorMessage = "Vui lòng chọn đánh giá từ 1 đến 5 sao.")]
    [Required]
    [Column("rating")]
    public int Rating { get; set; }

    [StringLength(500, ErrorMessage = "Nội dung đánh giá không được vượt quá 500 ký tự.")]
    [Column("comment")]
    public string? Comment { get; set; }

    [Column("created_at")]
    public DateTime? CreatedAt { get; set; } = DateTime.Now;

    [ValidateNever]
    public virtual Product Product { get; set; } = null!;
}

