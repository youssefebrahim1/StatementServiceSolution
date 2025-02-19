using Microsoft.EntityFrameworkCore;
using StatementServiceAPI.Models;
using System.Collections.Generic;

namespace StatementServiceAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Statement> Statements { get; set; }
    }
}
