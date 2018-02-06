using System;
using System.Collections.Generic;
using System.Text;

namespace BlogLib 
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        // YUCK!!! This shouldn't be here, but it makes EF SOOOOO much easier.
        // Navigation Properties
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
