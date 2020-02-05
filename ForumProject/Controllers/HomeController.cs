using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ForumProject.Models;
using ForumProject.Data;
using ForumProject.Models.Home;
using ForumProject.Models.Post;
using ForumProject.Data.Models;
using ForumProject.Models.Forum;

namespace ForumProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPost _postService;

        public HomeController(IPost postService)
        {
            _postService = postService;
        }
        public IActionResult Index()
        {
            var model = BuildHomeIndexModel();
            return View(model);
        }

        private HomeIndexModel BuildHomeIndexModel()
        {
            var latestPosts = _postService.getLatestPosts(10);
            var posts = latestPosts.Select(post => new PostListingModel
            {
                id = post.id,
                title = post.title,
                author = post.user.UserName,
                authorId = post.user.Id,
                authorRating = post.user.rating,
                datePosted = post.created.ToString(),
                nrOfReplies = post.replies.Count(),

                forum = getForumListingModelForPost(post)
            });
            return new HomeIndexModel
            {
                latestPosts = posts,
                searchQuery = ""
            };
        }

        private ForumListingModel getForumListingModelForPost(Post post)
        {
            var forum = post.forum;
            return new ForumListingModel
            {
                name = forum.title,
                forumImageUrl = forum.imageUrl,
                id = forum.id
            };
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
