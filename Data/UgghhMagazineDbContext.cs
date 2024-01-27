using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using UgghhMagazine.Models;
using Microsoft.AspNetCore.Identity;

namespace UgghhMagazine.Data;
public class UgghhMagazineDbContext : IdentityDbContext<IdentityUser>
{
    private readonly IConfiguration _configuration;
    public DbSet<Category> Category { get; set; }
    public DbSet<Likes> Likes { get; set; }
    public DbSet<Post> Post { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }

    public UgghhMagazineDbContext(DbContextOptions<UgghhMagazineDbContext> context, IConfiguration config) : base(context)
    {
        _configuration = config;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Id = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
            Name = "Admin",
            NormalizedName = "admin"
        });

        modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
        {
            Id = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
            UserName = "Administrator",
            Email = "admina@strator.comx",
            PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, _configuration["AdminPassword"])
        });

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            RoleId = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
            UserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f"
        });
        modelBuilder.Entity<UserProfile>().HasData(new UserProfile
        {
            Id = 1,
            IdentityUserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
            FirstName = "Admina",
            LastName = "Strator",
            Address = "101 Main Street",
        });

        modelBuilder.Entity<Category>().HasData(
        new Category { Id = 1, Name = "Poetry" },
        new Category { Id = 2, Name = "Short Story" },
        new Category { Id = 3, Name = "Opinion" }
    );

     modelBuilder.Entity<Post>().HasData(
        new Post { Id = 1, Title = "A Poem is Poetry", Author = "Author A", UserProfileId = 1, Date = DateTime.Now, CategoryId = 1, Content = "Exciting tech news!" },
        new Post { Id = 2, Title = "A Short Story is Hard to Write",Author = "Author b", UserProfileId = 1, Date = DateTime.Now, CategoryId = 2, Content = "Latest fashion trends!" },
        new Post { Id = 3, Title = "Travel Boom Leads to Gentrification",Author = "Author c", UserProfileId = 1, Date = DateTime.Now, CategoryId = 3, Content = "Amazing travel adventures!" }
    );

        
    }
}