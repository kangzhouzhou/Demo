using System;
using System.Collections.Generic;
using System.Text;

namespace EFConsole.Db
{
    /// <summary>
    /// 博客
    /// </summary>
    public class Blog
    {
        public int BlogId { get; set; }

        public string Url { get; set; }

        public List<Post> Posts { get; set; }
    }
}
