using beautyclinic_uni.Models;
using Microsoft.EntityFrameworkCore;

namespace beautyclinic_uni.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ContactRequest> ContactRequests { get; set; }
    }
}
