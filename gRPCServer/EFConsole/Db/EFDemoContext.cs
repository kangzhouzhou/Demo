using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFConsole.Db
{
    public class EFDemoContext:DbContext
    {
        public EFDemoContext()
        { 
        }

        public EFDemoContext(DbContextOptions<EFDemoContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityTypeBuilder<Blog> blogBuilder = modelBuilder.Entity<Blog>();
            blogBuilder.HasKey(x => x.BlogId);
            blogBuilder.Property(x => x.Url).HasMaxLength(2000);

            EntityTypeBuilder<Post> postBuilder= modelBuilder.Entity<Post>();
            postBuilder.HasKey(x => x.PostId);
            postBuilder.Property(x => x.Title).HasMaxLength(50);

            //双导航属性,Blog和Post配置一边即可
            postBuilder.HasOne(x => x.Blog).WithMany(y => y.Posts).OnDelete

            EntityTypeBuilder<User> userBuilder = modelBuilder.Entity<User>();
            userBuilder.HasKey(x => x.UserId);
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
