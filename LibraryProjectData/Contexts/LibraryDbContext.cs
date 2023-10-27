using LibraryProject.Models.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data.Contexts
{
    internal class LibraryDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies()
                .UseSqlServer("Data Source=STHQ0124-07;Initial Catalog=LibraryDb;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=False;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<T_Card> TCard { get; set; }
        public virtual DbSet<S_Card> SCard { get; set; }
        public virtual DbSet<Groupp> Groupss { get; set; }
        public virtual DbSet<Press> Presss { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Theme> Themess { get; set; }
        public virtual DbSet<Faculty> Facultiess { get; set; }
        public virtual DbSet<Lib> Libss { get; set; }
        public virtual DbSet<Department> Departmentss { get; set; }
        public virtual DbSet<Student> Studentss { get; set; }


    }
}
