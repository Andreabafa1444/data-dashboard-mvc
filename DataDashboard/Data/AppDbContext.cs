using Microsoft.EntityFrameworkCore;
using DataDashboard.Models;

namespace DataDashboard.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<StudentSocialMedia> StudentSocialMedias { get; set; }
}
