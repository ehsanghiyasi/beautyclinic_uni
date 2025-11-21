using beautyclinic_uni.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace YourProjectName.Data
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
