using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EFConsole.Db
{
    public class User
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
