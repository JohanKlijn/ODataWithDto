using System.Data.Entity;
using ODataWebApplication.Entities.Dal;
using SQLite.CodeFirst;

namespace ODataWebApplication.Repsositories
{
    public class TestDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }

        public TestDbContext()
            : base("default")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<TestDbContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);

        }
    }
}