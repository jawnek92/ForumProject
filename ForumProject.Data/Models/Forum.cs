using System;
using System.Collections.Generic;
using System.Text;

namespace ForumProject.Data.Models
{
    public class Forum
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public string ImageUrl { get; set; }
        public virtual IEnumerable<Post> Posts { get; set; }
    }
}
