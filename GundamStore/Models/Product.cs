using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OmegaStore.Models;

public partial class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Tự động tăng 
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    [Column("product_code")]
    public string ProductCode { get; set; } = null!;

    [Required(ErrorMessage = "Tên sản phẩm là bắt buộc.")]
    [StringLength(255, ErrorMessage = "Tên sản phẩm không được vượt quá 255 ký tự.")]
    [Column("name")]
    public string Name { get; set; } = null!;

    [Required]
    [StringLength(255)]
    [Column("thumbnail")]
    public string Thumbnail { get; set; } = null!;

    [Required(ErrorMessage = "Giá sản phẩm là bắt buộc")]
    [Range(0, double.MaxValue, ErrorMessage = "Giá phải lớn hơn hoặc bằng 0.")]
    [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Giá sản phẩm phải là số và không âm.")]
    public decimal Price { get; set; }


    [Required(ErrorMessage = "Tỷ lệ giảm giá phải nằm trong khoảng từ 0 đến 100.")]
    [Range(0, 100, ErrorMessage = "Tỷ lệ giảm giá phải nằm trong khoảng từ 0 đến 100.")]
    [Column("discount_rate", TypeName = "int")]
    public int DiscountRate { get; set; }

    [Required]
    [StringLength(255)]
    [Column("slug")]
    public string Slug { get; set; } = null!;

    [Required(ErrorMessage = "Số lượng tồn kho là bắt buộc!")]
    [Range(0,int.MaxValue,ErrorMessage = "Số lượng tồn kho phải lớn hơn hoặc bằng 0.")]
    [Column("stock")]
    public int Stock { get; set; }

    [Column("description", TypeName = "ntext")]
    public string? Description { get; set; }

    [Required,Range(1,int.MaxValue,ErrorMessage = "Danh mục là bắt buộc.")]
    [Column("category_id")]
    public int CategoryId { get; set; }

    [Required]
    [Column("status")]
    public int Status { get; set; }
	public DateTime? CreatedAt { get; set; } = DateTime.Now;

	public virtual Category Category { get; set; } = null!;
    public virtual ICollection<DetailOrder> DetailOrders { get; set; } = new List<DetailOrder>();
    public virtual ICollection<ProductsImage> ProductsImages { get; set; } = new List<ProductsImage>();
    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
    public virtual ICollection<Wishlist> Wishlists { get; set; } = new List<Wishlist>();
}

