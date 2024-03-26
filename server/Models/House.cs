namespace gregslist_csharp.Models;

public class House
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
    public int Year { get; set; }

    public int Price { get; set; }

    public string ImgUrl { get; set; }

    public string Description { get; set; }

    public string CreatorId { get; set; }
}