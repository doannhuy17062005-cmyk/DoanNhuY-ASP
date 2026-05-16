using Microsoft.AspNetCore.Mvc;
using CMS.Data.Entities;
using System.Collections.Generic;

namespace CMS.Backend.Controllers
{
    // Controller xử lý chức năng người dùng
    public class UserController : Controller
    {
        // Action hiển thị danh sách người dùng
        public IActionResult Index()
        {
            // Tạo danh sách người dùng mẫu
            var users = new List<User>
            {
                new User
                {
                    Id = 1,
                    Username = "admin_thai",
                    FullName = "Nguyễn Cao Thái",
                    Role = "Administrator"
                },
                new User
                {
                    Id = 2,
                    Username = "editor_01",
                    FullName = "Trần Văn Biên Tập",
                    Role = "Editor"
                },
                new User
                {
                    Id = 3,
                    Username = "author_minh",
                    FullName = "Lê Quang Minh",
                    Role = "Author"
                }
            };

            // Trả danh sách người dùng sang View
            return View(users);
        }
    }
}