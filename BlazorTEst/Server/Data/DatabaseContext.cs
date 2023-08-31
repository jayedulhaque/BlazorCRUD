using BlazorTEst.Shared;
using Microsoft.EntityFrameworkCore;
using BlazorTEst.Shared.Models;

namespace BlazorTEst.Server.Data
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext()
        {
        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        public virtual DbSet<User> Users { get; set; } = null!;
    }
}
