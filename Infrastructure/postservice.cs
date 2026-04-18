namespace Infrastructure;

public class Class1
{

public class Post
{

    public string Title { get; set; }
    public string Description { get; set; }
    public int LikeCount { get; set; }
    public List<string> Comments { get; set; } 
    public bool IsPublished { get; set; }

    public Post(string title, string description)
    {
        Title = title;
        Description = description;
    }
     public void Publish()
    {
        System.Console.WriteLine("The post is published.");
        IsPublished = true;
    }
     public void Like()
    {
        LikeCount++;
    }
      public void Comment(string message)
    {
        Comments.Add(message);
    }
}

}
