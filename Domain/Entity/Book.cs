using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public class Book
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public int Rating { get; set; }
        public int Publisher_Id { get; set; }
        public Publisher Publisher { get; set; }

        public virtual ICollection<BookAuthor> BookAuthors { get; set; }


       

    }
}
