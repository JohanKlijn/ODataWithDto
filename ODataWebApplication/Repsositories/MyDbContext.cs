using System.Data.Common;
using System.Data.Entity;
using ODataWebApplication.Entities.Dal;
using ODataWebApplication.Entities.Dal.Configuration;
using SQLite.CodeFirst;


namespace ODataWebApplication.Repsositories
{
    /// <summary>
    /// Supervision database context.
    /// </summary>
    public class MyDbContext : DbContext
    {
        /// <summary>
        /// Ctor which receives DbConnection to connect to the database.
        /// </summary>
        public MyDbContext() : base("default")
        {            
        }



        /// <summary>
        /// Review queues.
        /// </summary>
        public DbSet<ReviewQueue> ReviewQueues { get; set; }

        /// <summary>
        /// Review queue items.
        /// </summary>
        public DbSet<ReviewQueueItem> ReviewQueueItems { get; set; }

        /// <summary>
        /// Interactions.
        /// </summary>
        public DbSet<Interaction> Interactions { get; set; }

        /// <summary>
        /// Interaction participants.
        /// </summary>
        public DbSet<Participant> Participants { get; set; }


        /// <inheritdoc />
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ReviewQueueConfiguration());
            modelBuilder.Configurations.Add(new ReviewQueueItemConfiguration());            
            modelBuilder.Configurations.Add(new InteractionConfiguration());
            modelBuilder.Configurations.Add(new ParticipantsConfiguration());


            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<MyDbContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);

        }      
    }
}
