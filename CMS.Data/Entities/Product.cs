using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Data.Entities
{
    // Class đại diện cho sản phẩm
    public class Product
    {
        // Khóa chính của sản phẩm
        [Key]
        public int Id { get; set; }

        // Tên sản phẩm, bắt buộc nhập
        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        public string Name { get; set; }

        // Mô tả sản phẩm
        public string? Description { get; set; }

        // Giá sản phẩm, không được nhỏ hơn 0
        [Range(0, double.MaxValue)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        // Số lượng tồn kho
        public int StockQuantity { get; set; }

        // Đường dẫn hình ảnh sản phẩm
        public string? ImageUrl { get; set; }

        // Khóa ngoại liên kết với danh mục sản phẩm
        public int CategoryProductId { get; set; }

        // Liên kết tới danh mục sản phẩm
        [ForeignKey("CategoryProductId")]
        public virtual CategoryProduct? CategoryProduct { get; set; }
    }
}