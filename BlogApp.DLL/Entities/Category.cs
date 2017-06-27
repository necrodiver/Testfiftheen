using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DLL.Entities
{
    /// <summary>
    /// 博客类型
    /// </summary>
    public partial class Category
    {
        public virtual ICollection<Blog> Blogs { get; set; }
        public Category()
        {
            Blogs = new HashSet<Blog>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string CategoryName { get; set; }
    }
}
