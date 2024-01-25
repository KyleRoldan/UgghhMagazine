
using Microsoft.AspNetCore.Identity;

namespace UgghhMagazine.Models;

public class Post
{
    public int Id { get; set; }
    public int? Title { get; set; }

    public int? UserProfileId { get; set; }
    public UserProfile? UserProfile { get; set; }

    public DateTime? Date { get; set; }

    public int? CategoryId { get; set; }

    public Category? Category { get; set; }

    public string? Content { get; set; }
    public IdentityUser? IdentityUser { get; set; }

    
}



