using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using BookStoreCorrected.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BookStoreCorrected.DAL
{
    public class BookContext : DbContext
    {
        public BookContext() : base("BookContext") { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}