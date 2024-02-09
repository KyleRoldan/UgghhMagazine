using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UgghhMagazine.Data;
using Microsoft.EntityFrameworkCore;
using UgghhMagazine.Models;
using UgghhMagazine.Models.DTOs;

namespace UgghhMagazine.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PostController : ControllerBase
{
    private UgghhMagazineDbContext _dbContext;

    public PostController(UgghhMagazineDbContext context)
    {
        _dbContext = context;
    }

[HttpGet]
[Authorize]
public IActionResult Get()
{
    return Ok(_dbContext.Post.Include(b => b.Category).ToList());
}

[HttpGet("{id}")]
[Authorize]
public IActionResult GetById(int id)
{
    Post post = _dbContext
        .Post
        .Include(b => b.Category)
        .Include(b => b.UserProfile)
        .Include(b => b.IdentityUser)
        .SingleOrDefault(b => b.Id == id);

    if (post == null)
    {
        return NotFound();
    }

    return Ok(post);
}

[HttpPut("{id}")]
[Authorize]
public IActionResult UpdatePost(Post post, int id)
{
    Post postToUpdate = _dbContext.Post.SingleOrDefault(p => p.Id == id);
    if (postToUpdate == null)
    {
        return NotFound();
    }
    else if (id != post.Id)
    {
        return BadRequest();
    }

    postToUpdate.Id = post.Id;
    postToUpdate.Title = post.Title;
    postToUpdate.CategoryId = post.CategoryId;
    postToUpdate.Author = post.Author;
    postToUpdate.Content = post.Content;

    _dbContext.SaveChanges();

    return NoContent();
}
// {
//   "id": 123,  // Replace with the actual post ID you want to update
//   "categoryId": 1,  // Replace with the new category ID
//   "date": "2024-01-30T12:00",  // Replace with the new date
//   "author": "New Author Name"  // Replace with the new author name
// }



 [HttpPost]
 [Authorize]
public IActionResult CreatePostCard(Post post)
{
    
    
    post.Date= DateTime.Now;


    _dbContext.Post.Add(post);

    _dbContext.SaveChanges();

    return Created($"/api/post{post.Id}", post);
}






[HttpDelete("{id}")]
[Authorize]
public IActionResult DeletePost(int id)
{
    Post postToDelete = _dbContext.Post.SingleOrDefault(p => p.Id == id);
    
    if (postToDelete == null)
    {
        return NotFound();
    }

    _dbContext.Post.Remove(postToDelete);
    _dbContext.SaveChanges();

    return NoContent();
}

[HttpGet("withLikes")]
[Authorize]
public IActionResult GetWithLikes()
{
    var postsWithLikes = _dbContext.Post
        .Include(p => p.Likes)
        .Select(p => new PostDTO
        {
            Id = p.Id,
            Title = p.Title,
            Author = p.Author,
            UserProfileId = p.UserProfileId,
            Date = p.Date,
            CategoryId = p.CategoryId,
            Content = p.Content,
            IdentityUser = p.IdentityUser,
            Likes = p.Likes.Select(l => new LikesDTO
            {
                Id = l.Id,
                UserProfileId = l.UserProfileId,
                UserProfile = l.UserProfile, // Include UserProfile in LikesDTO if needed
                PostId = l.PostId,
                Post = l.Post // Include Post in LikesDTO if needed
            }).ToList()
        })
        .ToList();

    return Ok(postsWithLikes);
}


}