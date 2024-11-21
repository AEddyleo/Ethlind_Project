using Ethlind_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Ethlind_Project.Data
{
    public class MemberDbContext : DbContext
    {
        public MemberDbContext(DbContextOptions<MemberDbContext> options)
        : base(options)
        { 
        }

        public DbSet<Booking>? Booking { get; set; }
    }
}
