using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DLL.Entities
{
    /// <summary>
    /// 评论
    /// </summary>
    public partial class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public DateTime CreationTime { get; set; }

        public int? BlogId { get; set; }
        public int? PosterId { get; set; }
        public virtual Blog Blog { get; set; }
        public virtual User User { get; set; }
    }
}
