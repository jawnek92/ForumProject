using System;
using System.Collections.Generic;
using System.Text;

namespace ForumProject.Data.Models
{
    public class Forum
    {
        public int id { get; set; }
        public String title { get; set; }
        public string description { get; set; }
        public DateTime created { get; set; }
        public string imageUrl { get; set; }
        public virtual IEnumerable<Post> posts { get; set; }
    }
}
