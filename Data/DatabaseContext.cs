using Microsoft.EntityFrameworkCore;
using PathFinder.Model;

namespace PathFinder.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
    public DbSet<Catagory> Catagories { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<AppliedJobs> Applied_Jobs { get; set; }
}