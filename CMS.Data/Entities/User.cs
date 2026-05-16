using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data.Entities
{
    // Class đại diện cho người dùng hệ thống
    public class User
    {
        // Khóa chính của người dùng
        public int Id { get; set; }

        // Tên đăng nhập
        public string Username { get; set; }

        // Mật khẩu đã mã hóa
        public string PasswordHash { get; set; }

        // Họ tên người dùng
        public string FullName { get; set; }

        // Vai trò người dùng: Admin, Editor,...
        public string Role { get; set; }
    }
}