namespace UgghhMagazine.Models;
public class Likes
{
    public int Id { get; set; }
    public int UserProfileId { get; set; }

    public UserProfile? UserProfile { get; set; }
    
    public int PostId { get; set; }

    public Post? Post { get; set; }

}