using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CMS.Data.Entities
{
    // Class đại diện cho danh mục sản phẩm
    public class CategoryProduct
    {
        // Khóa chính của danh mục sản phẩm
        [Key]
        public int Id { get; set; }

        // Tên danh mục sản phẩm, bắt buộc nhập
        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [StringLength(100)]
        public string Name { get; set; }

        // Mô tả danh mục sản phẩm
        public string? Description { get; set; }

        // Danh sách sản phẩm thuộc danh mục này
        public virtual ICollection<Product>? Products { get; set; }
    }
}