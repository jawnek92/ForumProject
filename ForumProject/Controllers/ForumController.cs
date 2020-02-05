﻿using ForumProject.Data;
using ForumProject.Data.Models;
using ForumProject.Models.Forum;
using ForumProject.Models.Post;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace ForumProject.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumService;
        private readonly IPost _postService;

        public ForumController(IForum forumService)
        {
            this._forumService = forumService;
        }

        public IActionResult Index()
        {
            var forums = _forumService.getAll().Select(forum => new ForumListingModel
            {
                id = forum.id,
                name = forum.title,
                description = forum.description
            });

            var model = new ForumIndexModel
            {
                forumList = forums
            };

            return View(model);
        }

        public IActionResult Topic(int id)
        {
            var forum = _forumService.getById(id);

            var posts = forum.posts;
            var postListings = posts.Select(post => new PostListingModel
            {
                id = post.id,
                authorId = post.user.Id,
                title = post.title,
                datePosted = post.created.ToString(),
                nrOfReplies = post.replies.Count(),
                forumListingModel = buildForumListing(post)
            });

            var model = new ForumTopicModel
            {
                forum = buildForumList(forum),
                posts = postListings
        };

            return View(model);
        }

        private ForumListingModel buildForumListing(Post post)
        {
            var forum = post.forum;
            return buildForumList(forum);
        }
        private ForumListingModel buildForumList(Forum forum)
        {
            return new ForumListingModel
            {
                id = forum.id,
                name = forum.title,
                description = forum.description,
                forumImageUrl = forum.imageUrl
            };
        }
    }
}