using Microsoft.EntityFrameworkCore;
using portfolio_backend.models;

namespace portfolio_backend.data{
    public class PortfolioContext: DbContext{
        public PortfolioContext(DbContextOptions<PortfolioContext> opt) : base(opt)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Experience> Experience { get; set; }
        public DbSet<Identifier> Identifier { get; set; }
    }
}