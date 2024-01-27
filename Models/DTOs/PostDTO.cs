
using Microsoft.AspNetCore.Identity;

namespace UgghhMagazine.Models.DTOs;

public class PostDTO
{
    public int Id { get; set; }
    public string? Title { get; set; }

    public string? Author { get; set; }

    public int? UserProfileId { get; set; }
    public UserProfile? UserProfile { get; set; }

    public DateTime? Date { get; set; }

    public int? CategoryId { get; set; }

    public Category? Category { get; set; }

    public string? Content { get; set; }
    public IdentityUser? IdentityUser { get; set; }

    
}
