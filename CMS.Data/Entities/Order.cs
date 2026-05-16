using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Data.Entities
{
    // Class đại diện cho đơn hàng
    public class Order
    {
        // Khóa chính của đơn hàng
        [Key]
        public int Id { get; set; }

        // Ngày tạo đơn hàng, mặc định là ngày hiện tại
        public DateTime OrderDate { get; set; } = DateTime.Now;

        // Khóa ngoại liên kết với khách hàng
        public int CustomerId { get; set; }

        // Trạng thái đơn hàng
        public int Status { get; set; }

        // Ghi chú đơn hàng
        public string? Notes { get; set; }

        // Liên kết tới thông tin khách hàng
        [ForeignKey("CustomerId")]
        public virtual Customer? Customer { get; set; }

        // Danh sách chi tiết đơn hàng
        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}