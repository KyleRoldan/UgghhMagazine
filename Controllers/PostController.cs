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

// [HttpGet("inventory")]
// [Authorize]
// public IActionResult Inventory()
// {
//     int inventory = _dbContext
//     .Bikes
//     .Where(b => b.WorkOrders.Any(wo => wo.DateCompleted == null))
//     .Count();

//     return Ok(inventory);
// }

}