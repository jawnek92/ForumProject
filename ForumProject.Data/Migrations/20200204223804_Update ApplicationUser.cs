using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ForumProject.Data.Migrations
{
    public partial class UpdateApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_posts_AspNetUsers_UserId",
                table: "posts");

            migrationBuilder.DropForeignKey(
                name: "FK_posts_forums_forumId",
                table: "posts");

            migrationBuilder.DropForeignKey(
                name: "FK_replies_posts_PostId",
                table: "replies");

            migrationBuilder.DropForeignKey(
                name: "FK_replies_replies_PostReplyId",
                table: "replies");

            migrationBuilder.DropForeignKey(
                name: "FK_replies_AspNetUsers_UserId",
                table: "replies");

            migrationBuilder.DropForeignKey(
                name: "FK_replies_forums_forumId",
                table: "replies");

            migrationBuilder.RenameColumn(
                name: "forumId",
                table: "replies",
                newName: "forumid");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "replies",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "replies",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "PostReplyId",
                table: "replies",
                newName: "PostReplyid");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "replies",
                newName: "Postid");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "replies",
                newName: "created");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "replies",
                newName: "content");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "replies",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_replies_forumId",
                table: "replies",
                newName: "IX_replies_forumid");

            migrationBuilder.RenameIndex(
                name: "IX_replies_UserId",
                table: "replies",
                newName: "IX_replies_userId");

            migrationBuilder.RenameIndex(
                name: "IX_replies_PostReplyId",
                table: "replies",
                newName: "IX_replies_PostReplyid");

            migrationBuilder.RenameIndex(
                name: "IX_replies_PostId",
                table: "replies",
                newName: "IX_replies_Postid");

            migrationBuilder.RenameColumn(
                name: "forumId",
                table: "posts",
                newName: "forumid");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "posts",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "posts",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "posts",
                newName: "created");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "posts",
                newName: "content");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "posts",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_posts_forumId",
                table: "posts",
                newName: "IX_posts_forumid");

            migrationBuilder.RenameIndex(
                name: "IX_posts_UserId",
                table: "posts",
                newName: "IX_posts_userId");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "forums",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "forums",
                newName: "imageUrl");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "forums",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "forums",
                newName: "created");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "forums",
                newName: "id");

            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "memberSince",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "profileImageUrl",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_posts_forums_forumid",
                table: "posts",
                column: "forumid",
                principalTable: "forums",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_posts_AspNetUsers_userId",
                table: "posts",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_replies_replies_PostReplyid",
                table: "replies",
                column: "PostReplyid",
                principalTable: "replies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_replies_posts_Postid",
                table: "replies",
                column: "Postid",
                principalTable: "posts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_replies_forums_forumid",
                table: "replies",
                column: "forumid",
                principalTable: "forums",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_replies_AspNetUsers_userId",
                table: "replies",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_posts_forums_forumid",
                table: "posts");

            migrationBuilder.DropForeignKey(
                name: "FK_posts_AspNetUsers_userId",
                table: "posts");

            migrationBuilder.DropForeignKey(
                name: "FK_replies_replies_PostReplyid",
                table: "replies");

            migrationBuilder.DropForeignKey(
                name: "FK_replies_posts_Postid",
                table: "replies");

            migrationBuilder.DropForeignKey(
                name: "FK_replies_forums_forumid",
                table: "replies");

            migrationBuilder.DropForeignKey(
                name: "FK_replies_AspNetUsers_userId",
                table: "replies");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "memberSince",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "profileImageUrl",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "replies",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "replies",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "forumid",
                table: "replies",
                newName: "forumId");

            migrationBuilder.RenameColumn(
                name: "created",
                table: "replies",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "content",
                table: "replies",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "Postid",
                table: "replies",
                newName: "PostId");

            migrationBuilder.RenameColumn(
                name: "PostReplyid",
                table: "replies",
                newName: "PostReplyId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "replies",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_replies_userId",
                table: "replies",
                newName: "IX_replies_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_replies_forumid",
                table: "replies",
                newName: "IX_replies_forumId");

            migrationBuilder.RenameIndex(
                name: "IX_replies_Postid",
                table: "replies",
                newName: "IX_replies_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_replies_PostReplyid",
                table: "replies",
                newName: "IX_replies_PostReplyId");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "posts",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "posts",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "forumid",
                table: "posts",
                newName: "forumId");

            migrationBuilder.RenameColumn(
                name: "created",
                table: "posts",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "content",
                table: "posts",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "posts",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_posts_userId",
                table: "posts",
                newName: "IX_posts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_posts_forumid",
                table: "posts",
                newName: "IX_posts_forumId");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "forums",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "imageUrl",
                table: "forums",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "forums",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "created",
                table: "forums",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "forums",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_posts_AspNetUsers_UserId",
                table: "posts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_posts_forums_forumId",
                table: "posts",
                column: "forumId",
                principalTable: "forums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_replies_posts_PostId",
                table: "replies",
                column: "PostId",
                principalTable: "posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_replies_replies_PostReplyId",
                table: "replies",
                column: "PostReplyId",
                principalTable: "replies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_replies_AspNetUsers_UserId",
                table: "replies",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_replies_forums_forumId",
                table: "replies",
                column: "forumId",
                principalTable: "forums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
