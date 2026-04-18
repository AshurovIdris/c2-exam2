using Domain.Models;

namespace Infrastructure.Services;

public class PostService
{
    private List<Post> posts = new List<Post>();

    public void AddPost(Post post)
    {
        posts.Add(post);
    }

    public List<Post> GetPosts()
    {
        return posts;
    }
}