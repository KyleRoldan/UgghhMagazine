using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UgghhMagazine.Data;
using Microsoft.EntityFrameworkCore;
using UgghhMagazine.Models;
using UgghhMagazine.Models.DTOs;

namespace UgghhMagazine.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
{
    private UgghhMagazineDbContext _dbContext;

    public CategoryController(UgghhMagazineDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
[Authorize]
public IActionResult Get()
{
    return Ok(_dbContext.Category.ToList());
}













}