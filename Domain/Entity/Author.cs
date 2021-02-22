using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
   public class Author
    {
        public int Author_Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<BookAuthor> BooksAuthors { get; set; }
    }
}
