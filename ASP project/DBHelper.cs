using ASP_project.DB;
using Microsoft.EntityFrameworkCore;

namespace ASP_project
{
public class DBHelper : DbContext
{
        public DBHelper()
        {
        }

        public DBHelper(DbContextOptions<DBHelper> options) : base(options)
		{

		}
		public DbSet<CV> CVs { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CV>().ToTable("CV");
		}

		
	}
}
