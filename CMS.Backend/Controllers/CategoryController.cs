using Microsoft.AspNetCore.Mvc;
using CMS.Data.Entities;
using System.Collections.Generic;

namespace CMS.Backend.Controllers
{
    // Controller xử lý chức năng danh mục
    public class CategoryController : Controller
    {
        // Action hiển thị danh sách danh mục
        public IActionResult Index()
        {
            // Tạo danh sách danh mục mẫu
            var list = new List<Category>
            {
                new Category
                {
                    Id = 1,
                    Name = "Tin Công Nghệ",
                    Description = "Review Laptop, AI"
                },
                new Category
                {
                    Id = 2,
                    Name = "Giáo Dục",
                    Description = "Thông tin tuyển sinh"
                }
            };

            // Trả dữ liệu danh mục sang View
            return View(list);
        }
    }
}