using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data.Entities
{
    // Class đại diện cho danh mục bài viết
    public class Category
    {
        // Mã danh mục
        public int Id { get; set; }
        // Tên danh mục
        public string Name { get; set; }
        // Mô tả danh mục
        public string Description { get; set; }
        // Danh sách bài viết thuộc danh mục này
        public virtual ICollection<Post> Posts { get; set; }
    }
}
