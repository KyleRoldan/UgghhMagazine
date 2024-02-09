namespace UgghhMagazine.Models.DTOs;
public class LikesDTO
{

    public int Id { get; set; }
    public int UserProfileId { get; set; }

    public UserProfile? UserProfile { get; set; }

    public int PostId { get; set; }

    public Post? Post { get; set; }

}