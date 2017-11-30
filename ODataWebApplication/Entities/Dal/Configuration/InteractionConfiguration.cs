using System.Data.Entity.ModelConfiguration;

namespace ODataWebApplication.Entities.Dal.Configuration
{
    /// <summary>
    /// Fluent API configuration for interactions.
    /// </summary>
    internal class InteractionConfiguration : EntityTypeConfiguration<Interaction>
    {
        public InteractionConfiguration()
        {
            this.
                ToTable("Interaction");
            this.
                HasKey(i => i.InteractionId);           
            this.
                Property(i => i.SourceIdentifier).
                HasColumnType("nvarchar").
                IsMaxLength()
                .IsRequired();
            this.Property(i => i.StartDate).
                HasColumnType("datetime").
                IsRequired();
            this.
                Property(i => i.Title).
                HasColumnType("nvarchar").
                IsMaxLength().
                IsRequired();
            this.
                Property(i => i.Type).
                HasColumnType("varchar").
                HasMaxLength(50).
                IsRequired();
            this.
                Property(i => i.IngestDate).
                HasColumnType("datetime").
                IsRequired();
            this.Property(i => i.RiskScore)
                .HasColumnType("smallint")
                .IsRequired();
            this.HasMany(i => i.Participants);

        }
    }
}
