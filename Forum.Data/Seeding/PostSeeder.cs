using Forum.Data.Models;

namespace Forum.Data.Seeding
{
    class PostSeeder
    {
        internal Post[] GeneratePost()
        {
            ICollection<Post> posts = new HashSet<Post>();
            Post currentPost;

            currentPost = new Post()
            {
                Title = "My first post",
                Content =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris id lobortis odio. Orci varius natoque penatibus et magnis dis parturient."
            };
            posts.Add(currentPost);

            currentPost = new Post()
            {
                Title = "My second post",
                Content =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec metus ipsum, scelerisque at velit ut, ultricies varius lorem."
            };
            posts.Add(currentPost);

            currentPost = new Post()
            {
                Title = "My third post",
                Content =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam interdum consectetur dictum. Proin nisi."
            };
            posts.Add(currentPost);

            return posts.ToArray();
        }

    }
}
