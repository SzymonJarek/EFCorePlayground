using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class Publisher
    {
        public int Publisher_Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
