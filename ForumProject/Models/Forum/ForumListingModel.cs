using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumProject.Models.Forum
{
    public class ForumListingModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string forumImageUrl { get; set; }
    }
}
