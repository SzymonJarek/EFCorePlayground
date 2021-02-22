using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public class FluentBookAuthorConfig : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> modelBuilder)
        {
            modelBuilder.HasKey(a => new { a.Id, a.Author_Id });
            modelBuilder.HasOne(b => b.Book)
                        .WithMany(ba => ba.BookAuthors)
                        .HasForeignKey(k => k.Id);
            modelBuilder.HasOne(a => a.Author)
                        .WithMany(bg => bg.BooksAuthors)
                        .HasForeignKey(k => k.Author_Id);
        }
    }
}
