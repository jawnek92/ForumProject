using ForumProject.Models.Forum;

namespace ForumProject.Models.Post
{
    public class PostListingModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int authorRating { get; set; }
        public int authorName { get; set; }
        public string authorId { get; set; }
        public string datePosted { get; set; }

        public int forumId { get; set; }
        public string forumImage { get; set; }
        public string forumName { get; set; }
        public ForumListingModel forum { get; set; }

        public int nrOfReplies { get; set; }

        public ForumListingModel forumListingModel { get; set; }


    }
}
