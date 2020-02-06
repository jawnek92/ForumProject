using ForumProject.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumProject.Models.Forum
{
    public class ForumTopicModel
    {
        public ForumListingModel forum { get; set; }
        public IEnumerable<PostListingModel> posts { get; set; }
        public string searchQuery { get; set; }
    }
}
