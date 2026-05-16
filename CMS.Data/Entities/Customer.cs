using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CMS.Data.Entities
{
    // Class đại diện cho khách hàng
    public class Customer
    {
        // Khóa chính của khách hàng
        [Key]
        public int Id { get; set; }

        // Họ tên khách hàng, bắt buộc nhập
        [Required]
        public string FullName { get; set; }

        // Email khách hàng, bắt buộc nhập và đúng định dạng email
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // Số điện thoại khách hàng
        public string? Phone { get; set; }

        // Địa chỉ khách hàng
        public string? Address { get; set; }

        // Mật khẩu khách hàng, bắt buộc nhập
        [Required]
        public string Password { get; set; }

        // Danh sách đơn hàng của khách hàng
        public virtual ICollection<Order>? Orders { get; set; }
    }
}