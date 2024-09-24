using entities_library.comment;
using entities_library.login;
using entities_library.post;
using Microsoft.EntityFrameworkCore;

namespace dao_library;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {}

    public DbSet<User>? Users { get; set; }
    public DbSet<Person>? Persons { get; set; }
    public DbSet<UserBan>? UserBans { get; set; }
    public DbSet<Post>? Posts { get; set; }
}
