using MultiDataSourceGenericRepository.BL.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MultiDataSourceGenericRepository.BL.Contexts
{
    public class ContextNPG : DbContext
    {
        public ContextNPG() : base("name=PostgreSQLContext")
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // To remove the plural names   
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}