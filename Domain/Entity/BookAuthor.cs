using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class BookAuthor
    {
        public int Id { get; set; }
        public int Author_Id { get; set; }

        public virtual Book Book { get; set; }
        public virtual Author Author { get; set; }

    }
}
