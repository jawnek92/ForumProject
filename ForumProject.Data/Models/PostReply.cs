using System;
using System.Collections.Generic;
using System.Text;

namespace ForumProject.Data.Models
{
    public class PostReply
    {
        public int id { get; set; }
        public string content { get; set; }
        public DateTime created { get; set; }
        public virtual ApplicationUser user { get; set; }
        
        public virtual Post post { get; set; }
    }
}
