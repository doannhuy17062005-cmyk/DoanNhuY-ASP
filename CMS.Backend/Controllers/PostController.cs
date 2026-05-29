/* Sinh viên: Đoàn Như Ý
* MSSV: 2123110511
* Lớp: CCQ2311M
* Ngày sửa: 29/05/2026
* Mô tả: Sử dụng kỹ thuật .Include() để nạp kèm dữ liệu danh mục (Category) tránh lỗi Null ở trang Index và Details
*/

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; // BẮT BUỘC phải có dòng này để dùng được hàm .Include()
using CMS.Data;
using CMS.Data.Entities;
using System.Linq;

namespace CMS.Backend.Controllers
{
    public class PostController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PostController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Tham số 'id' được truyền vào từ URL (ví dụ: /Post/Index/5)
        public IActionResult Index(int? id)
        {
            // 1. Kiểm tra nếu không có id truyền vào thì trả về lỗi hoặc toàn bộ bài viết
            if (id == null)
            {
                return BadRequest("Vui lòng cung cấp mã danh mục.");
            }

            // 2. Sử dụng LINQ với tham số 'id' linh hoạt
            var posts = _context.Posts
                        .Where(p => p.CategoryId == id)
                        .OrderByDescending(p => p.CreatedDate)
                        .Include(p => p.Category)
                        .ToList();

            // 3. Truyền dữ liệu ra View
            return View(posts);
        }

        // Action Xem chi tiết bài viết
        public IActionResult Details(int id)
        {
            var post = _context.Posts
                               .Include(p => p.Category)
                               .FirstOrDefault(p => p.Id == id);

            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }
    }
}