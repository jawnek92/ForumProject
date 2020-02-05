using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumProject.Data;
using ForumProject.Data.Models;
using ForumProject.Models.Post;
using ForumProject.Models.Reply;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ForumProject.Controllers
{
    public class PostController : Controller
    {
        private readonly IPost _postService;
        private readonly IForum _forumService;

        private static UserManager<ApplicationUser> _userManager;

        public PostController(IPost postService, IForum forumService, UserManager<ApplicationUser> userManager)
        {
            this._postService = postService;
            this._forumService = forumService;
            _userManager = userManager;
        }

        public IActionResult create(int id)
        {
            var forum = _forumService.getById(id);
            var model = new NewPostModel
            {
                forumName = forum.title,
                forumId = forum.id,
                forumImageUrl = forum.imageUrl,
                authorName =  User.Identity.Name
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> addPost(NewPostModel model)
        {
            var userId = _userManager.GetUserId(User);
            var user = _userManager.FindByIdAsync(userId).Result;
            var post = BuildPost(model, user);

            _postService.add(post).Wait(); //Block the current thread until task is done
            //maybe user rating addition
            return RedirectToAction("Index", "Post", new { id = post.id });
        }

        private Post BuildPost(NewPostModel model, ApplicationUser user)
        {
            var forum = _forumService.getById(model.forumId);
            return new Post
            {
                title = model.title,
                content = model.content,
                created = DateTime.Now,
                user = user,
                forum = forum
            };
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
