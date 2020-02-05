using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumProject.Models.Forum
{
    public class ForumIndexModel
    {
        public IEnumerable<ForumListingModel> forumList { get; set; }
    }
}
