using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumProject.Data;
using ForumProject.Data.Models;
using ForumProject.Models.Reply;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ForumProject.Controllers
{
    public class ReplyController : Controller
    {
        private readonly IForum _forumService;
        private readonly IPost _postService;
        private readonly UserManager<ApplicationUser> _userManager;
        

        public ReplyController(IForum forumService, IPost postService, UserManager<ApplicationUser> userManager)
        {
            this._forumService = forumService;
            this._postService = postService;
            this._userManager = userManager;
        }

        public async Task<IActionResult> Create(int id)
        {
            var post = _postService.getById(id);
            var forum = _forumService.getById(post.forum.id);

            var userId = _userManager.GetUserId(User);
            var user = _userManager.FindByIdAsync(userId).Result;

            var model = new PostReplyModel
            {
                postContent = post.content,
                postTitle = post.title,
                postId = post.id,

                forumName = forum.title,
                forumId = forum.id,
                forumImageUrl = forum.imageUrl,

                authorName = User.Identity.Name,
                authorId = user.Id,

                created = DateTime.Now
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddReply(PostReplyModel model)
        {
            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);

            var reply = BuildReply(model, user);
            await _postService.addReply(reply);

            return RedirectToAction("Index", "Post", new { id = model.postId });
        }

        private PostReply BuildReply(PostReplyModel reply, ApplicationUser user)
        {
            var now = DateTime.Now;
            var post = _postService.getById(reply.postId);

            return new PostReply
            {
                post = post,
                content = reply.replyContent,
                created = now,
                user = user
            };
        }
    }
}
