using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ODataWebApplication.Entities.Dal.Configuration
{
    /// <summary>
    /// Fluent API configuration for review queues.
    /// </summary>
    internal class ReviewQueueConfiguration : EntityTypeConfiguration<ReviewQueue>
    {
        public ReviewQueueConfiguration()
        {
            this.
                ToTable("ReviewQueue");
            this.
                HasKey(rq => rq.Id);
            //this.
            //    Property(rq => rq.Id).
            //    HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.
                Property(rq => rq.CreateDate).
                HasColumnType("datetime").
                IsRequired();
            this.
                Property(rq => rq.LastModifiedDate).
                HasColumnType("datetime")
                .IsRequired();
            this.
                Property(rq => rq.Title).
                HasColumnType("nvarchar").
                HasMaxLength(100)
                .IsRequired();
            this.
                Property(rq => rq.Description).
                HasColumnType("nvarchar").
                HasMaxLength(1024);
            this.
                Property(rq => rq.Query).
                HasColumnType("nvarchar").
                IsMaxLength().
                IsRequired();
            this.
                Property(rq => rq.Creator).
                HasColumnType("uniqueidentifier").
                IsRequired();
            this.HasMany(rq => rq.ReviewQueueItems);
        }
    }
}
