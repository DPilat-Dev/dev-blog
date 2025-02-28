using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBlog.Core.Entities
{
    public class BlogPost
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Slug { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public DateTime PublishedAt { get; set; } = DateTime.Now;

        public string UserId { get; set; } = string.Empty;

        public User? Author { get; set; }
    }
}
