using Microsoft.EntityFrameworkCore;
using portfolio_backend.models;

namespace portfolio_backend.data{
    public class PortfolioContext: DbContext{
        public PortfolioContext(DbContextOptions<PortfolioContext> opt) : base(opt)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}