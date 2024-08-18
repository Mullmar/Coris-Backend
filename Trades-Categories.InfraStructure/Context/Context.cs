using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Trades_Categories.Domain.Entities;

namespace Trades_Categories.InfraStructure.Context
{
    public class Context : DbContext
    {
        public readonly IConfiguration _configuration;
        public Context(IConfiguration configuration, DbContextOptions<Context> options) : base(options) { 
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var typeDatabase = _configuration["TypeDatabase"];
            var conn = _configuration.GetConnectionString(typeDatabase);

            if (typeDatabase == "SQLServer") { 
                optionsBuilder.UseSqlServer(conn);
            }
        }
        public DbSet<Rules> CategoriesRules { get; set; }
        public DbSet<Sectors> Sector { get; set; }
    }
}
