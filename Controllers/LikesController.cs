using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UgghhMagazine.Data;
using Microsoft.EntityFrameworkCore;
using UgghhMagazine.Models;
using UgghhMagazine.Models.DTOs;

namespace UgghhMagazine.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LikesController : ControllerBase
{
    private UgghhMagazineDbContext _dbContext;

    public LikesController(UgghhMagazineDbContext context)
    {
        _dbContext = context;
    }


[HttpGet("{postId}/{userId}")]
[Authorize]
public IActionResult GetLikesByUserAndPostId(int postId, int userId)
{
    var likes = _dbContext.Likes
        .Where(l => l.PostId == postId && l.UserProfileId == userId)
        .ToList();

    if (likes.Count == 0)
    {
        return NotFound("No likes found for the specified user and post.");
    }

    return Ok(likes);
}

[HttpPost("{postId}/{userId}")]
[Authorize]
public IActionResult CreateLike(int postId, int userId)
{

    var existingLike = _dbContext.Likes
        .SingleOrDefault(l => l.PostId == postId && l.UserProfileId == userId);

    if (existingLike != null)
    {
        return Conflict("User has already liked the post.");
    }

    var newLike = new Likes
    {
        PostId = postId,
        UserProfileId = userId
    };

    _dbContext.Likes.Add(newLike);
    _dbContext.SaveChanges();

    return Created($"/api/likes/{postId}/{userId}", newLike);
}

[HttpDelete("{postId}/{userId}")]
[Authorize]
public IActionResult DeleteLike(int postId, int userId)
{
    var likeToDelete = _dbContext.Likes
        .SingleOrDefault(l => l.PostId == postId && l.UserProfileId == userId);

    if (likeToDelete == null)
    {
        return NotFound("Like not found for the specified user and post.");
    }

    _dbContext.Likes.Remove(likeToDelete);
    _dbContext.SaveChanges();

    return NoContent();
}


}