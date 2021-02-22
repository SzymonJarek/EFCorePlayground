using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore;
using System;

namespace Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author> Authors { get; set; }

        public DbSet<BookAuthor> BookAuthors { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=library;user=root;password=AtutAdmin1");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasKey(i => i.Id); 
            modelBuilder.Entity<Author>().HasKey(i => i.Author_Id);

            modelBuilder.Entity<Book>().Property(t => t.Title).IsRequired();
            modelBuilder.Entity<Book>().Property(t => t.Title).HasMaxLength(15);

            modelBuilder.Entity<Publisher>().HasKey(i => i.Publisher_Id);
            modelBuilder.Entity<Book>()
                        .HasOne(b => b.Publisher)
                        .WithMany(b => b.Books)
                        .HasForeignKey(b => b.Publisher_Id);

            modelBuilder.ApplyConfiguration(new FluentBookAuthorConfig());

        }


    }
}
