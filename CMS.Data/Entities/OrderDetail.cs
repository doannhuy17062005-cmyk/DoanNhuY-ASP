using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Data.Entities
{
    // Class đại diện cho chi tiết đơn hàng
    public class OrderDetail
    {
        // Khóa chính của chi tiết đơn hàng
        [Key]
        public int Id { get; set; }

        // Khóa ngoại liên kết với đơn hàng
        public int OrderId { get; set; }

        // Khóa ngoại liên kết với sản phẩm
        public int ProductId { get; set; }

        // Số lượng sản phẩm trong đơn hàng
        public int Quantity { get; set; }

        // Giá sản phẩm tại thời điểm đặt hàng
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }

        // Liên kết tới bảng đơn hàng
        [ForeignKey("OrderId")]
        public virtual Order? Order { get; set; }

        // Liên kết tới bảng sản phẩm
        [ForeignKey("ProductId")]
        public virtual Product? Product { get; set; }
    }
}