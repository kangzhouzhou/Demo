using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFConsole.Db
{
    /// <summary>
    /// 帖子,自动创建阴影属性
    /// </summary>
    public class Post
    {
        public int PostId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int BlogKey { get; set; }
        public Blog Blog { get; set; }
    }
}
