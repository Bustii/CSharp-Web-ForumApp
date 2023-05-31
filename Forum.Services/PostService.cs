﻿using Forum.Data;
using Forum.Data.Models;
using Forum.Services.Interfaces;
using Forum.ViewModels.Post;
using Microsoft.EntityFrameworkCore;

namespace Forum.Services
{
    public class PostService : IPostService
    {
        private readonly ForumDbContext dbContext;

        public PostService(ForumDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<PostListViewModel>> ListAllAsync()
        {
            IEnumerable<PostListViewModel> allPosts = await dbContext
                .Posts
                .Select(p => new PostListViewModel()
                {
                    Id = p.Id.ToString(),
                    Title = p.Title,
                    Content = p.Content
                })
                .ToArrayAsync();

            return allPosts;
        }

        public async Task AddPostAsync(PostAddFormModel postViewModel)
        {
            Post newPost = new Post()
            {
                Title = postViewModel.Title,
                Content = postViewModel.Content
            };

            await this.dbContext.Posts.AddAsync(newPost);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<PostAddFormModel> GetForEditOrDeleteByIdAsync(string id)
        {
            Post postToEdit = await this.dbContext
                .Posts
                .FirstAsync(p => p.Id.ToString() == id);

            return new PostAddFormModel()
            {
                Title = postToEdit.Title,
                Content = postToEdit.Content
            };
        }

        public async Task EditByIdAsync(string id, PostAddFormModel postEditedModel)
        {
            Post postToEdit = await this.dbContext
                .Posts
                .FirstAsync(p => p.Id.ToString() == id);

            postToEdit.Title = postEditedModel.Title;
            postToEdit.Content = postEditedModel.Content;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(string id)
        {
            Post postToDelete = await this.dbContext
                .Posts
                .FirstAsync(p => p.Id.ToString() == id);

            this.dbContext.Posts.Remove(postToDelete);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
