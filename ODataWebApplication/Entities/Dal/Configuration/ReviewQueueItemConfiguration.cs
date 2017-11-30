using System.Data.Entity.ModelConfiguration;

namespace ODataWebApplication.Entities.Dal.Configuration
{
    /// <summary>
    /// Fluent API configuration for review queue items.
    /// </summary>
    internal class ReviewQueueItemConfiguration : EntityTypeConfiguration<ReviewQueueItem>
    {
        public ReviewQueueItemConfiguration()
        {
            this.
                ToTable("ReviewQueueItem");
            this.
                HasKey(rqi => new {rqi.ReviewQueueId, rqi.InteractionId});            
            //this.
            //    HasRequired(rqi => rqi.ReviewQueue).
            //    WithMany(rq => rq.ReviewQueueItems).
            //    HasForeignKey(rqi => rqi.ReviewQueueId);
            this.Property(rqi => rqi.Assignee)
                .HasColumnType("uniqueidentifier")
                .IsRequired();
            this.Property(rqi => rqi.SelectionDate)
                .HasColumnType("datetime")
                .IsRequired();
            this.HasRequired(rqi => rqi.Interaction);
            //    WithMany(i => i.ReviewQueueItems).
            //    HasForeignKey(rqi => rqi.InteractionId);
        }
    }
}
