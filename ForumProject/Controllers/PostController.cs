using System;
using System.Collections.Generic;
using System.Linq;
using ForumProject.Data;
using ForumProject.Data.Models;
using ForumProject.Models.Post;
using ForumProject.Models.Reply;
using Microsoft.AspNetCore.Mvc;

namespace ForumProject.Controllers
{
    public class PostController : Controller
    {
        private readonly IPost _postService;
        public PostController(IPost postService)
        {
            this._postService = postService;
        }

        public IActionResult Index(int id)
        {
            var post = _postService.getById(id);
            var replies = BuildPostReplies(post.replies);

            var model = new PostIndexModel
            {
                id = post.id,
                title = post.title,
                authorId = post.user.Id,
                authorName = post.user.UserName,
                authorImageUrl = post.user.profileImageUrl,
                authorRathing = post.user.rating,
                created = post.created,
                content = post.content,
                replies = replies
            };
            return View(model);
        }

        private IEnumerable<PostReplyModel> BuildPostReplies(IEnumerable<PostReply> replies)
        {
            return replies.Select(reply => new PostReplyModel
            {
                id = reply.id,
                authorName = reply.user.UserName,
                authorId = reply.user.Id,
                authorImageUrl = reply.user.profileImageUrl,
                authorRating = reply.user.rating,
                created = reply.created,
                content = reply.content
            });
        }
    }
}
