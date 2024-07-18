using Article.core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Article.Data.SqlServerEF
{
    public class DBContext:DbContext
    {
        //public DBContext(DbContextOptions<DBContext> options) : base(options)
        //{

        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-O9QJ2IG;Database=Article;Trusted_Connection=True;");
        //}
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorPost> AuthorPosts { get; set; }
    }
}
