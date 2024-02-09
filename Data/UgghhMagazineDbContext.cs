using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using UgghhMagazine.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing.Tree;

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
        modelBuilder.Entity<UserProfile>().HasData(
            new UserProfile
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
        new Post { Id = 1, Title = "A Poem is Poetry", Author = "Author A", UserProfileId = 1, Date = DateTime.Now.AddDays(-5), CategoryId = 1, Content = "Exciting tech news!" },
        new Post { Id = 2, Title = "A Short Story is Hard to Write", Author = "Author B", UserProfileId = 1, Date = DateTime.Now.AddDays(-10), CategoryId = 2, Content = "Latest fashion trends!" },
        new Post { Id = 3, Title = "Travel Boom Leads to Gentrification", Author = "Author C", UserProfileId = 1, Date = DateTime.Now.AddDays(-15), CategoryId = 3, Content = "Amazing travel adventures!" },
        new Post { Id = 4, Title = "The Quest for the Perfect Pizza", Author = "Pizza Lover", UserProfileId = 1, Date = DateTime.Now.AddDays(-7), CategoryId = 1, Content = "Exploring the pizza world!" },
        new Post { Id = 5, Title = "Dancing with Robots", Author = "Tech Dancer", UserProfileId = 1, Date = DateTime.Now.AddDays(-12), CategoryId = 2, Content = "Innovative dance moves with robots!" },
        new Post { Id = 6, Title = "Surreal Paintings in Virtual Reality", Author = "VR Artist", UserProfileId = 1, Date = DateTime.Now.AddDays(-20), CategoryId = 3, Content = "Immersive art experiences!" },
        new Post { Id = 7, Title = "Adventures in Underwater Basket Weaving", Author = "Aqua Weaver", UserProfileId = 1, Date = DateTime.Now.AddDays(-8), CategoryId = 1, Content = "Unique aquatic crafting!" },
        new Post { Id = 8, Title = "Epic Pillow Fort Construction", Author = "Fort Architect", UserProfileId = 1, Date = DateTime.Now.AddDays(-18), CategoryId = 2, Content = "Building the ultimate pillow fortress!" },
        new Post { Id = 9, Title = "The Science of Sock Matching", Author = "Sock Scientist", UserProfileId = 1, Date = DateTime.Now.AddDays(-14), CategoryId = 3, Content = "Unraveling the mysteries of sock pairs!" },
        new Post { Id = 10, Title = "Space Travel on a Budget", Author = "Budget Astronaut", UserProfileId = 1, Date = DateTime.Now.AddDays(-11), CategoryId = 1, Content = "Exploring the cosmos without breaking the bank!" },
        new Post { Id = 11, Title = "Time-Traveling Cookbook Adventures", Author = "Chef Chronos", UserProfileId = 1, Date = DateTime.Now.AddDays(-17), CategoryId = 2, Content = "Cooking across different eras!" },
        new Post { Id = 12, Title = "Secrets of Invisible Ink", Author = "Ink Detective", UserProfileId = 1, Date = DateTime.Now.AddDays(-9), CategoryId = 3, Content = "Unveiling hidden messages!" },
        new Post { Id = 13, Title = "World Record for Paper Airplane Flight", Author = "Paper Pilot", UserProfileId = 1, Date = DateTime.Now.AddDays(-13), CategoryId = 1, Content = "Achieving new heights with paper airplanes!" },
        new Post { Id = 14, Title = "Extreme Juggling in Zero Gravity", Author = "Zero-G Juggler", UserProfileId = 1, Date = DateTime.Now.AddDays(-16), CategoryId = 2, Content = "Juggling feats in outer space!" },
        new Post { Id = 15, Title = "Gourmet Insect Tasting", Author = "Entomophagist", UserProfileId = 1, Date = DateTime.Now.AddDays(-19), CategoryId = 3, Content = "Culinary adventures with insects!" },
        new Post { Id = 16, Title = "Skydiving with Feathered Friends", Author = "Avian Adrenaline Junkie", UserProfileId = 1, Date = DateTime.Now.AddDays(-21), CategoryId = 1, Content = "Soaring through the skies with birds!" },
        new Post { Id = 17, Title = "Alien Communication through Dance", Author = "Extraterrestrial Dancer", UserProfileId = 1, Date = DateTime.Now.AddDays(-6), CategoryId = 2, Content = "Interstellar dance language!" },
        new Post { Id = 18, Title = "Mysteries of Quantum Baking", Author = "Quantum Baker", UserProfileId = 1, Date = DateTime.Now.AddDays(-22), CategoryId = 3, Content = "Baking with a quantum twist!" },
        new Post { Id = 19, Title = "Unicorn Tracking Expeditions", Author = "Unicorn Enthusiast", UserProfileId = 1, Date = DateTime.Now.AddDays(-23), CategoryId = 1, Content = "Seek"}
    );


         modelBuilder.Entity<Likes>().HasData(
        new Likes { Id = 1, UserProfileId = 1, PostId = 1 }, 
        new Likes { Id = 2, UserProfileId = 1, PostId = 3 },  
        new Likes { Id = 3, UserProfileId = 1, PostId = 5 }   
        );

         

        
    }
}