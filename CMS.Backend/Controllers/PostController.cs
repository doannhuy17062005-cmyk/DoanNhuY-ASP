using Microsoft.AspNetCore.Mvc;
using CMS.Data.Entities;
using System;
using System.Collections.Generic;

namespace CMS.Backend.Controllers
{
    // Controller xử lý chức năng bài viết
    public class PostController : Controller
    {
        // Action hiển thị danh sách bài viết
        public IActionResult Index()
        {
            // Tạo danh sách bài viết mẫu
            var posts = new List<Post>
            {
                new Post
                {
                    Id = 1,
                    Title = "Lộ trình học ASP.NET Core cho người mới",
                    Content = "Nội dung bài viết về lộ trình học .NET...",
                    ImageUrl = "https://via.placeholder.com/150",
                    CreatedDate = DateTime.Now
                },
                new Post
                {
                    Id = 2,
                    Title = "ReactJS và WebAPI: Xu hướng Fullstack 2026",
                    Content = "Nội dung bài viết về sự kết hợp React và API...",
                    ImageUrl = "https://via.placeholder.com/150",
                    CreatedDate = DateTime.Now.AddDays(-1)
                },
                new Post
                {
                    Id = 3,
                    Title = "Hướng dẫn cài đặt môi trường Visual Studio",
                    Content = "Các bước cài đặt công cụ cần thiết cho lập trình viên...",
                    ImageUrl = "https://via.placeholder.com/150",
                    CreatedDate = DateTime.Now.AddDays(-2)
                }
            };

            // Trả danh sách bài viết sang View
            return View(posts);
        }

        // Action hiển thị chi tiết bài viết theo Id
        public IActionResult Details(int id)
        {
            // Tạo dữ liệu chi tiết bài viết mẫu
            var post = new Post
            {
                Id = id,
                Title = "Nội dung chi tiết bài viết số " + id,
                Content = "Đây là nội dung đầy đủ của bài viết mà bạn vừa click vào.",
                ImageUrl = "https://via.placeholder.com/600x300",
                CreatedDate = DateTime.Now
            };

            // Trả bài viết sang View chi tiết
            return View(post);
        }
    }
}