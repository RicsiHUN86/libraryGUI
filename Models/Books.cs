using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace libraryGUI.Models
{
    public partial class Books
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public DateTime? PublishDate { get; set; }
        public int? AuthorId { get; set; }
        public int? CategoryId { get; set; }

        public virtual Authors Author { get; set; }
        public virtual Categories Category { get; set; }
    }
}
