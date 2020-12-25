using IdentityServer.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityServer.Context
{
    public class IdentityServerContext : DbContext
    {
        public IdentityServerContext(DbContextOptions<IdentityServerContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
