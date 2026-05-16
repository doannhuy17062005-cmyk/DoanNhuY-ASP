using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace CMS.Data.Entities
{
    // Class đại diện cho bài viết
    public class Post
    {
        // Khóa chính của bài viết
        public int Id { get; set; }

        // Tiêu đề bài viết
        public string Title { get; set; }

        // Nội dung bài viết
        public string Content { get; set; }

        // Đường dẫn hình ảnh bài viết
        public string ImageUrl { get; set; }

        // Ngày tạo bài viết, mặc định là ngày hiện tại
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Khóa ngoại liên kết với danh mục
        public int CategoryId { get; set; }

        // Liên kết tới danh mục của bài viết
        public virtual Category Category { get; set; }
    }
}