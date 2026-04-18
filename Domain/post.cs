namespace Domain;

public class Post
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int LikeCount { get; set; }
    public List<string> Comments { get; set; } 
    public bool IsPublished { get; set; }

}

